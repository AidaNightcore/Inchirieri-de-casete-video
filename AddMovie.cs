using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri_de_casete_video
{
    public partial class AddMovie : Form
    {
        private List<Movie> movies = new List<Movie>();
        private DataHandler dataHandler;
        private string moviesFilePath;

        public AddMovie(List<Movie> movies, string moviesFilePath)
        {
            InitializeComponent();
            this.movies = movies;
            this.moviesFilePath = moviesFilePath;
            this.dataHandler = new DataHandler(moviesFilePath, null, null);
        }

        private void InitializeComboBox()
        {
            
        }

        private void ageRatingDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            string id = movieNameTB.Text.ToString() + moviePublishDatePicker.Value.ToString();
            string name = movieNameTB.Text;  
            DateTime publishDate = moviePublishDatePicker.Value.Date;
            decimal price = priceNumeric.Value;
            int copies = (int)copiesNumeric.Value; 
            AgeRating ageRating = (AgeRating)ageRatingDrop.SelectedItem;
            int rating = 0; 
            string genre = genreTB.Text;
            string[] langauges = langaugesTB.Text.Split(',');

            Movie newMovie = new Movie(id, name, price, ageRating, rating, publishDate, copies, genre, langauges);


            movies.Add(newMovie);
            dataHandler.SaveMovies(movies);

            this.Close();
        }
    }
}
