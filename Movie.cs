using System;

namespace Inchirieri_de_casete_video
{
    public enum Genre
    {
        Action,
        Romance,
        Kids,
        Psychological,
        Horror
    }
    public enum AgeRating
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }

    public class Movie
    {
        private int id;
        private string name;
        private DateTime publishDate;
        private int rating;
        private decimal price;
        private AgeRating ageRating;
        private int copies;
        private Genre genre;
        private string[] languages;
        private string imageData;
        public string ImageData { get => imageData; set => imageData = value; }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public int Rating { get => rating; set => rating = value; }
        public AgeRating AgeRating { get => ageRating; set => ageRating = value; }
        public int Copies { get => copies; set => copies = value; }
        public decimal Price { get => price; set => price = value; }
        public Genre Genre { get => genre; set => genre = value; }
        public string[] Languages { get => languages; set => languages = value; }

        public Movie(int v_id, string v_name, decimal v_price, AgeRating v_ageRating, int v_rating, DateTime v_publishDate, int v_copies, Genre v_genre, string[] v_languages, string v_imageData)
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
            imageData = v_imageData;
        }


        public object Clone()
        {
            Movie copy = (Movie)this.MemberwiseClone();
            string[] languagesNew = (string[])languages.Clone();
            copy.languages = languagesNew;
            return copy;
        }

        public void SetLanguages(string languagesCommaSeparated)
        {
            if (!string.IsNullOrEmpty(languagesCommaSeparated))
            {
                languages = languagesCommaSeparated.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < languages.Length; i++)
                {
                    languages[i] = languages[i].Trim();
                }
            }
            else
            {
                languages = new string[] { };
            }
        }

        public override string ToString()
        {
            string languagesStr = string.Join(", ", languages);
            string result = $"ID: {id}\nName: {name}\nPrice: {price}\nAgeRating: {ageRating}\nRating: {rating}\nPublish Date: {publishDate}\nCopies: {copies}\nGenre: {genre}\nLanguages: {languagesStr}";
            return result;
        }

        public static Movie operator *(Movie movie, decimal factor)
        {
            Movie newMovie = (Movie)movie.Clone();
            newMovie.Price *= factor;
            return newMovie;
        }


    }
}
