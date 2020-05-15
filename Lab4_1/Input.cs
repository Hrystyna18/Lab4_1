using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_1
{
    class Input
    {
        public static void InitialisingStudent()
        {
            Console.WriteLine("Введіть данi.");

            InitialisingStudentName();
            InitialisingStudentLastname();
            InitialisingStudentGroup();
            InitialisingStudentYear();
            InitialisingStudentAdress();
            InitialisingStudentPassport();
            InitialisingStudentAge();
            InitialisingStudentTelephone();
            InitialisingStudentRating();
        }

        private static void InitialisingStudentName()
        {
            Console.Write("Iм'я: ");

            Program.Hrystyna.Name = Console.ReadLine();
        }

        private static void InitialisingStudentLastname()
        {
            Console.Write("Прiзвище: ");

            Program.Hrystyna.LastName = Console.ReadLine();
        }

        private static void InitialisingStudentGroup()
        {
            Console.Write("Група: ");

            Program.Hrystyna.Group = Console.ReadLine();
        }

        private static void InitialisingStudentAdress()
        {
            Console.Write("Адреса проживання: ");

            Program.Hrystyna.Adress = Console.ReadLine();
        }

        private static void InitialisingStudentYear()
        {
            Console.Write("Рiк вступу: ");

            Program.Hrystyna.Year = int.Parse(Console.ReadLine());
        }

        private static void InitialisingStudentPassport()
        {
            Console.Write("Номер паспорта: ");

            Program.Hrystyna.Passport = Console.ReadLine();
        }

        private static void InitialisingStudentAge()
        {
            Console.Write("Вiк: ");

            Program.Hrystyna.Age = int.Parse(Console.ReadLine());
        }

        private static void InitialisingStudentTelephone()
        {
            Console.Write("Номер телефону: ");

            Program.Hrystyna.Telephone = Console.ReadLine();
        }

        private static void InitialisingStudentRating()
        {
            Console.Write("Середнiй бал: ");

            Program.Hrystyna.Rating = int.Parse(Console.ReadLine());
        }
    }
}


