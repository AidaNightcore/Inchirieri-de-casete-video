using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddMovie : Form
    {
        private DataAccess dataAccess;
        private string imagePath; // Store the path of the image

        public AddMovie(DataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;

            // Initialize the age rating drop-down
            InitializeAgeRatingDropDown();

            pictureDragDrop.AllowDrop = true;

            pictureDragDrop.DragEnter += pictureDragDrop_DragEnter;
            pictureDragDrop.DragDrop += pictureDragDrop_DragDrop;
        }

        private void InitializeAgeRatingDropDown()
        {
            // Get the enum values as an array of strings
            string[] ageRatings = Enum.GetNames(typeof(AgeRating));

            // Set the ComboBox data source to the array of strings
            ageRatingDrop.DataSource = ageRatings;
        }

        private void pictureDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged data is an image
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file(s) dropped onto the PictureBox
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Check if only one file is dropped and it is an image
            if (files.Length == 1 && IsImageFile(files[0]))
            {
                // Store the path of the image
                imagePath = files[0];

                // Load the image into the PictureBox
                pictureDragDrop.Image = Image.FromFile(files[0]);
            }
            else
            {
                MessageBox.Show("Please drop only one image file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method to check if a file is an image file
        private bool IsImageFile(string filePath)
        {
            try
            {
                Image img = Image.FromFile(filePath);
                img.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int id = random.Next();
                string name = movieNameTB.Text;
                DateTime publishDate = moviePublishDatePicker.Value.Date;
                decimal price = priceNumeric.Value;
                int copies = (int)copiesNumeric.Value;

                // Parse the selected item from the ComboBox to AgeRating enum
                if (Enum.TryParse<AgeRating>(ageRatingDrop.SelectedItem.ToString(), out AgeRating ageRating))
                {
                    int rating = 0;
                    Genre genre = (Genre)comboBox1.SelectedItem;

                    string languagesText = langaugesTB.Text;
                    string[] languages = languagesText.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    // Store the imagePath in the database
                    Movie newMovie = new Movie(id, name, price, ageRating, rating, publishDate, copies, genre, languages, imagePath);

                    dataAccess.AddMovie(newMovie);

                    MessageBox.Show("Movie added successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Age Rating selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
