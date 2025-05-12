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



namespace MochaMemoirs
{
    public enum AppTheme
    {
        Light,
        Dark
    }
    public partial class MochaMemoirsForm : Form
    {
        private List<Book> libraryBooks;
        private int currentBookIndex = 0;
        private Timer currentDateTimer;
        private string currentDate = "";
        private string previousDate = "";

        public MochaMemoirsForm()
        {
            InitializeComponent();
            RoundButton(HomeButton);
            RoundButton(LibraryButton);
            RoundButton(SettingsButton);
            InitDateLabel();
            initTimeLabel();
            TransparentLabels(DateLabel, TimeLabel);
            ApplyTheme(false);
        }

        private void MochaMemoirsForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            ApplyTheme(false);
            ThemeComboBox.SelectedIndexChanged += ThemeComboBox_SelectedIndexChanged;
        }

        private void ApplyTheme(bool darkMode)
        {
            Color backgroundColor = darkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;
            Color textColor = darkMode ? Color.White : Color.Black;
            ViewLibrariesPanel.BackColor = darkMode ? Color.FromArgb(30, 30, 30) : Color.WhiteSmoke;

            this.BackColor = backgroundColor;

            foreach (Control control in this.Controls)
            {
                ApplyThemeToControl(control, backgroundColor, textColor, darkMode);
            }
        }

        private void ApplyThemeToControl(Control control, Color backColor, Color foreColor, bool darkMode)
        {
            if (control is Button btn)
            {
                btn.BackColor = darkMode ? Color.MediumPurple : Color.PeachPuff;
                btn.ForeColor = Color.MidnightBlue;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
            else if (control is System.Windows.Forms.Label lbl)
            {
                if (lbl.Name == "TitleLabel" || lbl.Name == "DateLabel" || lbl.Name == "TimeLabel")
                {
                    lbl.ForeColor = Color.White;
                }
                else
                {
                    lbl.ForeColor = foreColor;
                }
                lbl.BackColor = Color.Transparent;
            }

            else
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;
            }

            foreach (Control child in control.Controls)
            {
                ApplyThemeToControl(child, backColor, foreColor, darkMode);
            }
        }


        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThemeComboBox.SelectedItem?.ToString() == "Dark")
                ApplyTheme(true);
            else
                ApplyTheme(false);
        }


        public void initTimeLabel()
        {
            currentDateTimer = new Timer();
            currentDateTimer.Interval = 1000;
            currentDateTimer.Tick += CurrentDateTimer_Tick;
            currentDateTimer.Start();
        }

        private void CurrentDateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeAndDateLabels();
        }

        private void UpdateTimeAndDateLabels()
        {
            DateTime current = DateTime.Now;
            TimeLabel.Text = current.ToString("hh:mm:ss tt");

            string currentDate = current.ToString("dddd, MMMM d");
            string suffix = "";

            if (currentDate != previousDate)
            {
                previousDate = currentDate;
                switch (current.Day)
                {
                    case 1: suffix = "st"; break;
                    case 2: suffix = "nd"; break;
                    case 3: suffix = "rd"; break;
                    default: suffix = "th"; break;
                }
            }
            DateLabel.Text = $"{current:dddd}, {current:MMMM} {current.Day}{suffix}";



        }

        private void LoadBooks()
        {
            string jsonFilePath = "books.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            Library jsonLibrary = JsonConvert.DeserializeObject<Library>(jsonContent);

            if (jsonLibrary != null && jsonLibrary.library != null)
            {
                libraryBooks = jsonLibrary.library;
            }
            else
            {
                libraryBooks = new List<Book>();
            }


            DisplayBook(currentBookIndex);

            var booksByGenre = libraryBooks
                .GroupBy(b => b.genreName)
                .ToDictionary(g => g.Key, g => g.ToList());

            PopulateGenres(booksByGenre);
        }

        private void PopulateGenres(Dictionary<string, List<Book>> booksByGenre)
        {   
            ViewLibrariesPanel.Controls.Clear();
            ViewLibrariesPanel.AutoScroll = true;

            int yOffset = 10;
            int maxPanelWidth = ViewLibrariesPanel.Width - 40; // Account for padding/scrollbar

            foreach (var genre in booksByGenre)
            {
                Panel genrePanel = new Panel
                {
                    Width = maxPanelWidth,
                    Location = new Point(10, yOffset),
                    Height = 35,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = false
                };

                System.Windows.Forms.Label headerLabel = new System.Windows.Forms.Label
                {
                    Text = genre.Key,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    Cursor = Cursors.Hand,
                    Location = new Point(5, 5)
                };

                Panel booksPanel = new Panel
                {
                    Location = new Point(0, 30),
                    Width = maxPanelWidth,
                    Height = genre.Value.Count * 105,
                    Visible = false,
                    AutoScroll = false
                };

                int bookYOffset = 5;

                foreach (var book in genre.Value)
                {
                    Panel bookPanel = new Panel
                    {
                        Location = new Point(10, bookYOffset),
                        Size = new Size(maxPanelWidth - 20, 100),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox cover = new PictureBox
                    {
                        Location = new Point(5, 5),
                        Size = new Size(60, 90),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        ImageLocation = Path.Combine(Application.StartupPath, book.image)
                    };

                    System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label
                    {
                        Text = book.bookTitle,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Location = new Point(75, 5),
                        AutoSize = true
                    };

                    System.Windows.Forms.Label authorLabel = new System.Windows.Forms.Label
                    {
                        Text = $"by {book.author}",
                        Font = new Font("Segoe UI", 9, FontStyle.Italic),
                        Location = new Point(75, 30),
                        AutoSize = true
                    };

                    System.Windows.Forms.Label publisherLabel = new System.Windows.Forms.Label
                    {
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

                headerLabel.Click += (s, e) =>
                {
                    booksPanel.Visible = !booksPanel.Visible;
                    genrePanel.Height = booksPanel.Visible ? booksPanel.Location.Y + booksPanel.Height : 35;
                };

                genrePanel.Controls.Add(headerLabel);
                genrePanel.Controls.Add(booksPanel);
                ViewLibrariesPanel.Controls.Add(genrePanel);

                yOffset += genrePanel.Height + 10;
            }
        }


        private void DisplayBook(int index)
        {
            if (libraryBooks.Count > 0)
            {
                var book = libraryBooks[index];
                FeaturedBookPictureBox.ImageLocation = Path.Combine(Application.StartupPath, book.image);
                FeaturedBookPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (currentBookIndex == libraryBooks.Count - 1)
            {
                currentBookIndex = 0;
            }
            else
            {
                currentBookIndex = currentBookIndex + 1;

                DisplayBook(currentBookIndex);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (currentBookIndex == 0)
            {
                currentBookIndex = libraryBooks.Count - 1;
            }
            else
            {
                currentBookIndex = currentBookIndex - 1;
            }

            DisplayBook(currentBookIndex);
        }

        // read
        private List<Book> LoadAllBooks()
        {
            string jsonFilePath = "books.json";
            if (!File.Exists(jsonFilePath)) return new List<Book>();

            string json = File.ReadAllText(jsonFilePath);
            var jsonLibrary = JsonConvert.DeserializeObject<Library>(json);
            if (jsonLibrary != null && jsonLibrary.library != null)
            {
                return jsonLibrary.library;
            }
            else
            {
                return new List<Book>();
            }
        }

        // write
        private void SaveAllBooks(List<Book> books)
        {
            string jsonFilePath = "books.json";
            var library = new Library { library = books };
            string json = JsonConvert.SerializeObject(library);
            File.WriteAllText(jsonFilePath, json);
        }

        // create
        public void AddBook(Book newBook)
        {
            var books = LoadAllBooks();
            books.Add(newBook);
            SaveAllBooks(books);
        }

        // update
        public void UpdateBook(Book updatedBook)
        {
            var books = LoadAllBooks();
            var index = books.FindIndex(b => b.bookId == updatedBook.bookId);
            if (index >= 0)
            {
                books[index] = updatedBook;
                SaveAllBooks(books);
            }
        }

        // delete
        public void DeleteBook(int bookId)
        {
            var books = LoadAllBooks();
            books.RemoveAll(b => b.bookId == bookId);
            SaveAllBooks(books);
        }


        public void InitDateLabel()
        {
            int numDay = System.DateTime.Now.Day;
            string nameDay = System.DateTime.Now.DayOfWeek.ToString();

            int numMonth = (int)DateTime.Now.Month;
            string nameMonth = "";

            string year = System.DateTime.Now.Year.ToString();

            string suffix = "";

            switch (numMonth)
            {
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

        private void RoundButton(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void TransparentLabels(params System.Windows.Forms.Label[] labels)
        {
            foreach (var label in labels)
            {
                label.BackColor = Color.Transparent;
            }
        }
        private void InitStages()
        {
            HomePanel.Visible = true;
            LibraryPanel.Visible = false;
            SettingsPanel.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            LibraryPanel.Visible = false;
            SettingsPanel.Visible = false;
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            LibraryPanel.Visible = true;
            SettingsPanel.Visible = false;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            HomePanel.Visible = false;
            LibraryPanel.Visible = false;
            SettingsPanel.Visible = true;
        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewLibrariesGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
