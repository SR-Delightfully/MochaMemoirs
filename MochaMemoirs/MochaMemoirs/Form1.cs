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



namespace MochaMemoirs
{
    public partial class MochaMemoirsForm : Form
    {
        private List<Book> libraryBooks;
        private int currentBookIndex = 0;

        public MochaMemoirsForm()
        {
            InitializeComponent();

            InitDateLabel();
        }

        private void MochaMemoirsForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
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

            switch (numDay)
            {
                case 1: suffix = "st"; break;
                case 2: suffix = "nd"; break;
                case 3: suffix = "rd"; break;
                default: suffix = "th"; break;
            }


            DateLabel.Text = nameDay + ", " + nameMonth + " " + numDay + suffix;
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

            DisplayBook(currentBookIndex);  // Show previous book
        }

    }
}

