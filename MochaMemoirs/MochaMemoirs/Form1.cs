using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Text.Json;
using DatabaseLib;
using MochaMemoirs.Model;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using Label = System.Windows.Forms.Label;


namespace MochaMemoirs
{
    //public interface IDatabaseService { }
    public partial class MochaMemoirsForm : Form {
        private List<Book> libraryBooks;
        private int currentBookIndex = 0;
        private Timer currentDateTimer;
        private string currentDate = "";
        private string previousDate = "";
        private string timeFormat = "hh:mm:ss tt";
        private User currentUser;
        private string username;
        private string password;
        private readonly IDatabaseService database;

        private Dictionary<string, Theme> themes = new Dictionary<string, Theme>()
        {
            { "Light", new Theme("Light", Color.MistyRose, Color.Indigo, Color.Plum, Color.Orchid) },
            { "Dark", new Theme("Dark", Color.Black, Color.Gainsboro, Color.DarkBlue, Color.MidnightBlue) },
            { "Sepia", new Theme("Sepia", Color.BurlyWood, Color.Maroon, Color.Peru, Color.Sienna) },
            { "LightSolarized", new Theme("LightSolarized", Color.Beige, Color.DimGray, Color.Khaki, Color.DarkKhaki) },
            { "DarkSolarized", new Theme("DarkSolarized", Color.DarkSlateGray, Color.Azure, Color.Teal, Color.CadetBlue) }
        };
        public MochaMemoirsForm(IDatabaseService database) {
            InitializeComponent();
            this.database = database;
            RoundButton(HomeButton);
            RoundButton(LibraryButton);
            RoundButton(SettingsButton);
            RoundButton(exitButton);
            InitDateLabel();
            initTimeLabel();
            TransparentLabels(DateLabel, TimeLabel);

            ThemeComboBox.SelectedIndexChanged += ThemeComboBox_SelectedIndexChanged;
            var user_id = database.createUser("John Doe", "john.doe@example.com", "password123");
        }

        private void MochaMemoirsForm_Load(object sender, EventArgs e) {
            LoadBooks();

            string selectedTheme = Properties.Settings.Default.AppTheme;

            if (!string.IsNullOrEmpty(selectedTheme) && themes.ContainsKey(selectedTheme)) {
                ThemeComboBox.SelectedItem = selectedTheme;
                ApplyTheme(themes[selectedTheme]);
            } else {
                ThemeComboBox.SelectedItem = "Light";
                ApplyTheme(themes["Light"]);
            }

            MinimizedCheckBox.Checked = Properties.Settings.Default.StartMinimized;
            comboBox1.SelectedItem = Properties.Settings.Default.DefaultPanel ?? "LoginPanel";

            if (MinimizedCheckBox.Checked)
                this.WindowState = FormWindowState.Minimized;

            ShowPanel(Properties.Settings.Default.DefaultPanel);
            InitSettingsEvents();
        }

        private void ShowPanel(string panelName) {
            HomePanel.Visible = (panelName == "HomePanel");
            LibraryPanel.Visible = (panelName == "LibraryPanel");
            SettingsPanel.Visible = (panelName == "SettingsPanel");
            loginPanel.Visible = (panelName == "LoginPanel");
            
        }

        private void InitSettingsEvents() {
            FontFamilyComboBox.SelectedIndexChanged += FontSettingsChanged;
            BoldCheckBox.CheckedChanged += FontSettingsChanged;
            ItalicCheckBox.CheckedChanged += FontSettingsChanged;

            HideDateCheckBox.CheckedChanged += DateTimeVisibilityChanged;
            HideTimeCheckBox.CheckedChanged += DateTimeVisibilityChanged;

            comboBox1.SelectedIndexChanged += StartupBehaviorChanged;
            MinimizedCheckBox.CheckedChanged += StartupBehaviorChanged;

            radioButton1.CheckedChanged += TimeFormatChanged;
            radioButton2.CheckedChanged += TimeFormatChanged;
        }
        private void TimeFormatChanged(object sender, EventArgs e) {
            if (radioButton1.Checked)
                timeFormat = "hh:mm:ss tt";
            else if (radioButton2.Checked)
                timeFormat = "HH:mm:ss";

            UpdateTimeAndDateLabels();
        }
        private void FontSettingsChanged(object sender, EventArgs e) {
            string fontFamily = FontFamilyComboBox.SelectedItem?.ToString() ?? "Segoe UI";
            FontStyle style = FontStyle.Regular;

            if (BoldCheckBox.Checked) style |= FontStyle.Bold;
            if (ItalicCheckBox.Checked) style |= FontStyle.Italic;

            Font newFont = new Font(fontFamily, 10, style);
            ApplyFontToControls(this.Controls, newFont);
        }
        private void FontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string selectedFont = FontFamilyComboBox.SelectedItem.ToString();
            Font newFont = new Font(selectedFont, 10);
        }
        private void ApplyFontToControls(Control.ControlCollection controls, Font font) {
            foreach (Control control in controls) {
                control.Font = new Font(font.FontFamily, control.Font.Size, font.Style);
                if (control.HasChildren)
                    ApplyFontToControls(control.Controls, font);
            }
        }
        private void ApplyThemeToControl(Control control, Theme theme) {
            control.BackColor = theme.BackgroundColor;
            control.ForeColor = theme.ForegroundColor;

            switch (control) {
                case Button btn:
                    btn.BackColor = theme.Accent1;
                    btn.ForeColor = theme.ForegroundColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = theme.Accent1;
                    btn.FlatAppearance.MouseOverBackColor = theme.Accent2;
                    btn.FlatAppearance.MouseDownBackColor = theme.Accent2;

                    btn.MouseEnter -= Button_MouseEnter;
                    btn.MouseLeave -= Button_MouseLeave;
                    btn.MouseEnter += Button_MouseEnter;
                    btn.MouseLeave += Button_MouseLeave;
                    break;

                case TextBox tb:
                    tb.BackColor = theme.BackgroundColor;
                    tb.ForeColor = theme.ForegroundColor;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    break;

                case ComboBox cb:
                    cb.BackColor = theme.BackgroundColor;
                    cb.ForeColor = theme.ForegroundColor;
                    cb.FlatStyle = FlatStyle.Flat;
                    break;

                case System.Windows.Forms.Label lbl:
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = theme.ForegroundColor;
                    break;

                case GroupBox gb:
                    gb.BackColor = theme.BackgroundColor;
                    gb.ForeColor = theme.ForegroundColor;
                    break;

                case Panel pnl:
                    pnl.BackColor = theme.BackgroundColor;
                    break;

                case DataGridView dgv:
                    dgv.BackgroundColor = theme.BackgroundColor;
                    dgv.ForeColor = theme.ForegroundColor;
                    dgv.GridColor = theme.Accent1;
                    dgv.DefaultCellStyle.BackColor = theme.BackgroundColor;
                    dgv.DefaultCellStyle.ForeColor = theme.ForegroundColor;
                    dgv.DefaultCellStyle.SelectionBackColor = theme.Accent2;
                    dgv.DefaultCellStyle.SelectionForeColor = theme.ForegroundColor;
                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = theme.Accent1;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = theme.ForegroundColor;
                    break;
            }

            foreach (Control child in control.Controls) {
                ApplyThemeToControl(child, theme);
            }
        }


        private void ApplyTheme(Theme theme) {
            this.BackColor = theme.BackgroundColor;

            ViewLibrariesPanel.BackColor = theme.BackgroundColor;
            LibraryPanel.BackColor = theme.BackgroundColor;
            SettingsPanel.BackColor = theme.BackgroundColor;

            foreach (Control control in this.Controls) {
                ApplyThemeToControl(control, theme);
            }
            this.TimeLabel.ForeColor = Color.White;
            this.DateLabel.ForeColor = Color.White;
            this.TitleLabel.ForeColor = Color.White;
        }
        
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (ThemeComboBox.SelectedItem == null || themes == null)
                return;
            string selectedKey = ThemeComboBox.SelectedItem.ToString();
            if (!themes.ContainsKey(selectedKey))
                return;
            if (sender is Button btn)
            {
                btn.BackColor = themes[selectedKey].Accent2;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (ThemeComboBox.SelectedItem == null || themes == null)
                return;
            string selectedKey = ThemeComboBox.SelectedItem.ToString();
            if (!themes.ContainsKey(selectedKey))
                return;
            if (sender is Button btn)
            {
                btn.BackColor = themes[selectedKey].Accent2;
            }
        }

        private void ClockFormatChanged(object sender, EventArgs e) {
            UpdateTimeAndDateLabels();
        }

        private void DateTimeVisibilityChanged(object sender, EventArgs e) {
            TimeLabel.Visible = !HideTimeCheckBox.Checked;
            DateLabel.Visible = !HideDateCheckBox.Checked;
        }

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = ThemeComboBox.SelectedItem?.ToString();

            if (themes.TryGetValue(selected, out var selectedTheme)) {
                ApplyTheme(selectedTheme);
                Properties.Settings.Default.AppTheme = selected;
                Properties.Settings.Default.Save();
            }
        }


        private void StartupBehaviorChanged(object sender, EventArgs e) {
            Properties.Settings.Default.StartMinimized = MinimizedCheckBox.Checked;
            Properties.Settings.Default.DefaultPanel = comboBox1.SelectedItem?.ToString() ?? "LoginPanel";
            Properties.Settings.Default.Save();
        }

        public void initTimeLabel() {
            currentDateTimer = new Timer();
            currentDateTimer.Interval = 1000;
            currentDateTimer.Tick += CurrentDateTimer_Tick;
            currentDateTimer.Start();
        }

        private void CurrentDateTimer_Tick(object sender, EventArgs e) {
            UpdateTimeAndDateLabels();
        }

        private void UpdateTimeAndDateLabels() {
            DateTime current = DateTime.Now;
            TimeLabel.Text = current.ToString(timeFormat);

            string currentDate = current.ToString("dddd, MMMM d");
            string suffix = GetDaySuffix(current.Day);

            DateLabel.Text = $"{current:dddd}, {current:MMMM} {current.Day}{suffix}";
        }

        private string GetDaySuffix(int day) {
            if (day >= 11 && day <= 13)
                return "th";

            switch (day % 10) {
                case 1: return "st";
                case 2: return "nd";
                case 3: return "rd";
                default: return "th";
            }
        }

        private void LoadBooks() {
            string jsonFilePath = "books.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            Library jsonLibrary = JsonConvert.DeserializeObject<Library>(jsonContent);

            if (jsonLibrary != null && jsonLibrary.library != null) {
                libraryBooks = jsonLibrary.library;
            } else {
                libraryBooks = new List<Book>();
            }


            DisplayBook(currentBookIndex);

            var booksByGenre = libraryBooks
                .GroupBy(b => b.genreName)
                .ToDictionary(g => g.Key, g => g.ToList());

            PopulateGenres(booksByGenre);
        }

        private void PopulateGenres(Dictionary<string, List<Book>> booksByGenre) {
            ViewLibrariesPanel.Controls.Clear();
            ViewLibrariesPanel.AutoScroll = true;

            int yOffset = 10;
            int maxPanelWidth = ViewLibrariesPanel.Width - 40; // Account for padding/scrollbar

            foreach (var genre in booksByGenre) {
                Panel genrePanel = new Panel {
                    Width = maxPanelWidth,
                    Location = new Point(10, yOffset),
                    Height = 35,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = false
                };

                System.Windows.Forms.Label headerLabel = new System.Windows.Forms.Label {
                    Text = genre.Key,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    Cursor = Cursors.Hand,
                    Location = new Point(5, 5)
                };

                Panel booksPanel = new Panel {
                    Location = new Point(0, 30),
                    Width = maxPanelWidth,
                    Height = genre.Value.Count * 105,
                    Visible = false,
                    AutoScroll = false
                };

                int bookYOffset = 5;

                foreach (var book in genre.Value) {
                    Panel bookPanel = new Panel {
                        Location = new Point(10, bookYOffset),
                        Size = new Size(maxPanelWidth - 20, 100),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox cover = new PictureBox {
                        Location = new Point(5, 5),
                        Size = new Size(60, 90),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        ImageLocation = Path.Combine(Application.StartupPath, book.image)
                    };

                    System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label {
                        Text = book.bookTitle,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Location = new Point(75, 5),
                        AutoSize = true
                    };

                    System.Windows.Forms.Label authorLabel = new System.Windows.Forms.Label {
                        Text = $"by {book.author}",
                        Font = new Font("Segoe UI", 9, FontStyle.Italic),
                        Location = new Point(75, 30),
                        AutoSize = true
                    };

                    System.Windows.Forms.Label publisherLabel = new System.Windows.Forms.Label {
                        Text = $"Published by {book.publisher}",
                        Font = new Font("Segoe UI", 8),
                        Location = new Point(75, 55),
                        AutoSize = true
                    };

                    bookPanel.Controls.Add(cover);
                    bookPanel.Controls.Add(titleLabel);
                    bookPanel.Controls.Add(authorLabel);
                    bookPanel.Controls.Add(publisherLabel);

                    booksPanel.Controls.Add(bookPanel);
                    bookYOffset += 105;
                }

                headerLabel.Click += (s, e) => {
                    booksPanel.Visible = !booksPanel.Visible;
                    genrePanel.Height = booksPanel.Visible ? booksPanel.Location.Y + booksPanel.Height : 35;
                };

                genrePanel.Controls.Add(headerLabel);
                genrePanel.Controls.Add(booksPanel);
                ViewLibrariesPanel.Controls.Add(genrePanel);

                yOffset += genrePanel.Height + 10;
            }
        }


        private void DisplayBook(int index) {
            if (libraryBooks.Count > 0) {
                var book = libraryBooks[index];
                FeaturedBookPictureBox.ImageLocation = Path.Combine(Application.StartupPath, book.image);
                FeaturedBookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void NextButton_Click(object sender, EventArgs e) {
            if (currentBookIndex == libraryBooks.Count - 1) {
                currentBookIndex = 0;
            } else {
                currentBookIndex = currentBookIndex + 1;

                DisplayBook(currentBookIndex);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e) {
            if (currentBookIndex == 0) {
                currentBookIndex = libraryBooks.Count - 1;
            } else {
                currentBookIndex = currentBookIndex - 1;
            }

            DisplayBook(currentBookIndex);
        }

        private List<Book> LoadAllBooks() {
            string jsonFilePath = "books.json";
            if (!File.Exists(jsonFilePath)) return new List<Book>();

            string json = File.ReadAllText(jsonFilePath);
            var jsonLibrary = JsonConvert.DeserializeObject<Library>(json);
            if (jsonLibrary != null && jsonLibrary.library != null) {
                return jsonLibrary.library;
            } else {
                return new List<Book>();
            }
        }

        private void SaveAllBooks() {
            var jsonLibrary = new Library { library = libraryBooks };
            string json = JsonConvert.SerializeObject(jsonLibrary, Formatting.Indented);
            File.WriteAllText("books.json", json);
        }


        public void AddBook(Book newBook) {
            var books = LoadAllBooks();
            books.Add(newBook);
            SaveAllBooks();
        }

        public void UpdateBook(Book updatedBook) {
            var books = LoadAllBooks();
            var index = books.FindIndex(b => b.bookId == updatedBook.bookId);
            if (index >= 0) {
                books[index] = updatedBook;
                SaveAllBooks();
            }
        }

        public void DeleteBook(string bookId) {
            var books = LoadAllBooks();
            books.RemoveAll(b => b.bookId == bookId);
            SaveAllBooks();
        }


        public void InitDateLabel() {
            int numDay = System.DateTime.Now.Day;
            string nameDay = System.DateTime.Now.DayOfWeek.ToString();

            int numMonth = (int)DateTime.Now.Month;
            string nameMonth = "";

            string year = System.DateTime.Now.Year.ToString();

            string suffix = "";

            switch (numMonth) {
                case 1: nameMonth = "January"; break;
                case 2: nameMonth = "February"; break;
                case 3: nameMonth = "March"; break;
                case 4: nameMonth = "April"; break;
                case 5: nameMonth = "May"; break;
                case 6: nameMonth = "June"; break;
                case 7: nameMonth = "July"; break;
                case 8: nameMonth = "August"; break;
                case 9: nameMonth = "September"; break;
                case 10: nameMonth = "October"; break;
                case 11: nameMonth = "November"; break;
                case 12: nameMonth = "December"; break;
                default: nameMonth = "N/A"; break;
            }
            DateLabel.Text = nameDay + ", " + nameMonth + " " + numDay + suffix;
        }

        private void RoundButton(Button button) {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void TransparentLabels(params System.Windows.Forms.Label[] labels) {
            foreach (var label in labels) {
                label.BackColor = Color.Transparent;
            }
        }

             private void InitStages() {
            HomePanel.Visible     = false;
            LibraryPanel.Visible  = false;
            SettingsPanel.Visible = false;
            loginPanel.Visible    = true;
            panel2.Visible        = false;
        }

        private void HomeButton_Click(object sender, EventArgs e) {
            HomePanel.Visible     = true;
            LibraryPanel.Visible  = false;
            SettingsPanel.Visible = false;
            loginPanel.Visible    = false;
            panel2.Visible        = false;
        }

        private void LibraryButton_Click(object sender, EventArgs e) {
            HomePanel.Visible     = false;
            LibraryPanel.Visible  = true;
            SettingsPanel.Visible = false;
            loginPanel.Visible    = false;
            panel2.Visible        = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e) {
            HomePanel.Visible     = false;
            LibraryPanel.Visible  = false;
            SettingsPanel.Visible = true;
            loginPanel.Visible    = false;
            panel2.Visible        = false;
        }

        private void createAccountBtn_Click(object sender, EventArgs e) {
            HomePanel.Visible     = false;
            LibraryPanel.Visible  = false;
            SettingsPanel.Visible = false;
            loginPanel.Visible    = false;
            panel2.Visible = true;
        }
        
        private void backToLogin_Click(object sender, EventArgs e) {
            HomePanel.Visible     = false;
            LibraryPanel.Visible  = false;
            SettingsPanel.Visible = false;
            loginPanel.Visible    = false;
            panel2.Visible        = true;
        }

        private void toCreateAccountBtn_onClick(object sender, EventArgs e) {
            HomePanel.Visible     = false;
            LibraryPanel.Visible  = false;
            SettingsPanel.Visible = false;
            loginPanel.Visible    = true;
            panel2.Visible        = false;
        }
        

        private void usernameInput_TextChanged(object sender, EventArgs e) {
            username = usernameInput.Text;
        }

        private void passwordInput_TextChanged(object sender, EventArgs e) {
            password = passwordInput.Text;
        }

        private void loadUserInfos(string username) {
            string[]       result    = (username.Contains('@')) ? database.getUserByEmail(username) : database.getUserByID(username);
            string[][]     libraries = database.getUserLibraries(username);
            
            PersonalLibraryGroupBox.Controls.Clear();
            
            int y = 20; // vertical position offset

            foreach (string[] book in libraries)
            {
                string libId = book[0];
                string isbn  = book[1];

                // Display as label
                Label bookLabel = new Label();
                bookLabel.Text     = $"ISBN: {isbn}";
                bookLabel.Location = new Point(10, y);
                bookLabel.AutoSize = true;
                PersonalLibraryGroupBox.Controls.Add(bookLabel);
                y += 25; // space between items
            }
            
            var groupedLibraries = libraries
                                   .GroupBy(lib => lib[0])
                                   .Select(g => new
                                                {
                                                    library_id = g.Key,
                                                    books      = g.Select(lib => lib[1]).ToArray()
                                                })
                                   .ToArray();

            // Construct the final user profile object
            var userProfile = new {
                                      user = new
                                             {
                                                 id    = result[0],
                                                 name  = result[1],
                                                 email = result[2]
                                             },
                                      libraries = groupedLibraries
                                  };

            string userJson = System.Text.Json.JsonSerializer.Serialize(userProfile, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
// Save to the same folder as books.json
            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userProfile.json");
            File.WriteAllText(userFilePath, userJson);                                                           
        }
    
        private void AddButton_Click(object sender, EventArgs e) {
            Book newBook = new Book {
                bookId = GetNextBookId().ToString(),
                bookTitle = titleTextBox.Text,
                author = authorTextBox.Text,
                publisher = publisherTextBox.Text,
                image = ""
            };

            libraryBooks.Add(newBook);
            SaveAllBooks();
            MessageBox.Show("Book added successfully!");
        }

        private void EditButton_Click(object sender, EventArgs e) {
            string id = bookIdTextBox.Text;
            var book = libraryBooks.FirstOrDefault(b => b.bookId == id);
            if (book != null) {
                book.bookTitle = titleTextBox.Text;
                book.author = authorTextBox.Text;
                book.publisher = publisherTextBox.Text;

                SaveAllBooks();
                MessageBox.Show("Book updated.");
            } else {
                MessageBox.Show("Book ID not found.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            string id = bookIdTextBox.Text;
            var book = libraryBooks.FirstOrDefault(b => b.bookId == id);
            if (book != null) {
                libraryBooks.Remove(book);
                SaveAllBooks();
                MessageBox.Show("Book deleted.");
            } else {
                MessageBox.Show("Book ID not found.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            saveChangesToDB();
            Application.Exit();
        }

        private void saveChangesToDB() {
            
        }

        private void LoadBooksIntoGrid() {
            string jsonFilePath = "books.json";
            if (!File.Exists(jsonFilePath)) {
                MessageBox.Show("File not found.");
                return;
            }

            string jsonContent = File.ReadAllText(jsonFilePath);
            Library jsonLibrary = JsonConvert.DeserializeObject<Library>(jsonContent);

            if (jsonLibrary != null && jsonLibrary.library != null) {
                booksDataGridView.DataSource = jsonLibrary.library;

                // Hide the image column
                if (booksDataGridView.Columns["image"] != null) {
                    booksDataGridView.Columns["image"].Visible = false;
                }
            } else {
                booksDataGridView.DataSource = null;
                MessageBox.Show("No books found.");
            }
        }

        private int GetNextBookId() {
            int maxId = 0;

            foreach (Book book in libraryBooks) {

                if (book.bookId.Length > 0) {
                    var id = book.bookId;
                    if (int.Parse(id) > maxId) {
                        maxId = int.Parse(id);
                    }
                }
            }

            return maxId + 1;
        }



        private void loadButton_Click(object sender, EventArgs e) {
            LoadBooksIntoGrid();
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            titleTextBox.Text = "";
            authorTextBox.Text = "";
            publisherTextBox.Text = "";
            bookIdTextBox.Text = "";
            genreTextBox.Text = "";
        }

        private void LanguageBox_SelectedIndexChanged(object sender, EventArgs e) {
            var changeLanguage = new ChangeLanguage();
            switch (LanguageBox.SelectedIndex) {
                case 0:
                    changeLanguage.UpdateConfig("language", "en");
                    Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("language", "fr-CA");
                    Application.Restart();
                    break;

                case 2:
                    changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    break;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {

        }

        private void loginBtn_onClick(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("ERROR: Username and/or password are required.");
                return;
            }

            string[] result;

            // Decide whether to search by email or ID
            if (username.Contains('@'))
            {
                result = database.getUserByEmail(username);
            }
            else
            {
                result = database.getUserByID(username);
            }

            if (result != null && result.Length > 3)
            {
                if (password.Equals(result[3]))  // Assuming password is at index 3
                {
                    MessageBox.Show("Login successful!");
                    loadUserInfos(username);
                    // Proceed with login flow
                }
                else
                {
                    MessageBox.Show("Incorrect password.");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }
    }

}
