using System;

namespace Inchirieri_de_casete_video
{
    public class Client
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime BirthdayDate { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }

        public Client(string id, string name, string surname, string phone, DateTime birthdayDate, string address)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            BirthdayDate = birthdayDate;
            Address = address;
        }

        public int Age()
        {
            int age = DateTime.Today.Year - BirthdayDate.Year;
            if (BirthdayDate.Date > DateTime.Today.AddYears(-age))
                age--;
            return age;
        }

        public int AgeRating()
        {
            if (Age() > 17)
            {
                return 4;
            }
            else if (Age() < 17 && Age() >= 13)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        public override string ToString()
        {
            return $"Client: {Name} {Surname}\nID: {Id}\nPhone Number: {Phone}\nBirthday: {BirthdayDate}\nAddress: {Address}\n";
        }
    }
}
