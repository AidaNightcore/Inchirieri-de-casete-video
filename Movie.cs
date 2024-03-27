using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video
{
    enum Genre
    {
        G,
        PG, 
        PG13,
        R,
        NC17
    }
    internal class Movie{
        private int id;
        private string name;
        private DateTime publishDate;
        private string rating;
        private int price;
        private Genre genre;
        private int copies;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
       
        public DateTime BirtdayDate { get => publishDate; set => publishDate = value; }
        public string Phone { get => rating; set => rating = value; }
        public Genre Genre { get => genre; set => genre = value; }
        public int Copies { get => copies; set => copies = value; }
        public int Price { get => price; set => price = value; }

        public Movie(int v_id, string v_name, Genre v_genre, string v_rating, DateTime v_publishDate, int v_copies)
        {
            id = v_id;
            name = v_name;
            rating = v_rating;
            genre = v_genre;
            copies = v_copies;  
            publishDate = v_publishDate;
            
        }
    }


}
