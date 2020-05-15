using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_1
{
    public class Student
    {
        private string _name;
        private string _lastName;
        private string _group;
        private string _adress;
        private string _passport;
        private string _telephone;
        private int _year;
        private int _age;
        private int _rating;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Group
        {
            get => _group;
            set => _group = value;
        }

        public string Adress
        {
            get => _adress;
            set => _adress = value;
        }

        public string Passport
        {
            get => _passport;
            set => _passport = value;
        }

        public string Telephone
        {
            get => _telephone;
            set => _telephone = value;
        }


        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public int Rating
        {
            get => _rating;
            set => _rating = value;
        }

        public Student()
        {
            Name = "Не вказано.";
            LastName = "Не вказано.";
            Group = "Не вказано.";
            Adress = "Не вказано.";
            Telephone = "Не вказано.";
            Year = 0;
            Age = 0;
            Rating = 0;
        }

        public string StudentRating()
        {
            if (_rating >= 90)
            {
                return "\nВiтаємо вiдмiнника";
            }

            if ((_rating < 90) && (_rating >= 75))
            {
                return "\nМожна вчитись краще";
            }

            if (_rating < 75)
            {
                return "\nВарто бiльше уваги придiляти навчанню";
            }

            return null;
        }
    }
}




