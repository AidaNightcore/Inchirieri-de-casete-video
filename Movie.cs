using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video
{
    public enum AgeRating
    {
        G,
        PG, 
        PG13,
        R,
        NC17
    }

    public class Movie{
        private string id;
        private string name;
        private DateTime publishDate;
        private int rating;
        private decimal price;
        private AgeRating ageRating;
        private int copies;
        private string genre;  
        private string[] languages;
        
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirtdayDate { get => publishDate; set => publishDate = value; }
        public int Rating { get => rating; set => rating = value; }
        public AgeRating AgeRating { get => ageRating; set => ageRating = value; }
        public int Copies { get => copies; set => copies = value; }
        public decimal Price { get => price; set => price = value; }
        public string[] Languages { get => languages; set => languages = value; }

        public Movie(string v_id, string v_name, decimal v_price, AgeRating v_ageRating, int v_rating, DateTime v_publishDate, int v_copies, string v_genre, string[] v_languages)
        {
            id = v_id;
            name = v_name;
            rating = v_rating;
            ageRating = v_ageRating;
            copies = v_copies;  
            publishDate = v_publishDate;
            price = v_price;
            genre = v_genre;
            languages = (string[])v_languages.Clone();
        }

        public object Clone()
        {
            Movie copy = (Movie)this.MemberwiseClone();
            string[] langaugesNew = (string[])languages.Clone();
            copy.languages = langaugesNew;
            return copy;
        }
    }
}
