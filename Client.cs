using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri_de_casete_video
{
    public class Client
    {
        private string id; 
        private string name;
        private string surname;
        private DateTime birthdayDate;
        private string phone;
        private string adress; 

        public string Id { get => id; set => id = value;  }
        public string Name { get => name; set => name = value; } 
        public string Surname { get => surname; set => surname = value; }
        public DateTime BirtdayDate { get => birthdayDate; set => birthdayDate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }
        
        public Client(string v_id, string v_name, string v_surname, string v_phone, DateTime v_birthdayDate, string v_adress) {
            id=v_id; 
            name=v_name;
            surname=v_surname;
            phone=v_phone;
            birthdayDate = v_birthdayDate;
            adress=v_adress;
        }

        public int age()
        {
            int age = DateTime.Today.Year - birthdayDate.Year;
            if (birthdayDate.Date > DateTime.Today.AddYears(-age))
                age--;
            return age;
        }

        public int ageRating(Client s)
        {
            if (s.age() > 17)
            {
                return 4;
            }
            else if (s.age() < 17 && s.age() >= 13)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }
        public object Clone()
        {
            Client copy = (Client)this.MemberwiseClone();
            return copy;
        }
    }
}
