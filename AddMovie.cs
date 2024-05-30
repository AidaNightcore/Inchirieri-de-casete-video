using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddMovie : Form
    {
        private DataAccess dataAccess;

        public AddMovie(DataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            ageRatingDrop.DataSource = Enum.GetValues(typeof(AgeRating));
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Guid.NewGuid().ToString(); // Generate a unique ID
                string name = movieNameTB.Text;
                DateTime publishDate = moviePublishDatePicker.Value.Date;
                decimal price = priceNumeric.Value;
                int copies = (int)copiesNumeric.Value;
                AgeRating ageRating = (AgeRating)ageRatingDrop.SelectedItem;
                int rating = 0; // Assume a default rating or collect from UI if needed
                Genre genre = (Genre)comboBox1.SelectedItem;

                // Get languages entered by the user
                string languagesText = langaugesTB.Text;
                string[] languages = languagesText.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Add new movie to database
                Movie newMovie = new Movie(id, name, price, ageRating, rating, publishDate, copies, genre, languages);
                dataAccess.AddMovie(newMovie);

                MessageBox.Show("Movie added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        
    }
}
