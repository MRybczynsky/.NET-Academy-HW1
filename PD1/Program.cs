using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak masz na imie?");
            var name = Console.ReadLine();

            Console.WriteLine("\nW ktorym roku sie urodziles?");
            var year = GetYear();

            Console.WriteLine("\nJakiego miesiaca?");
            var month = GetMonth();

            Console.WriteLine("\nJakiego dnia?");
            var day = GetDay(year,month);

            Console.WriteLine("\nW jakiej miejscowosci?");
            var place = Console.ReadLine();

            var dateOfBirth = new DateTime(year, month, day);
            var age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age--;
            var welcome = $"Cześć {name} urodziles sie w {place} i masz {age} lat!";
            Console.WriteLine(welcome);
            Console.ReadLine();
        }

        private static int GetDay(int year, int month)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day > DateTime.DaysInMonth(year,month) || day < 1)
                {
                    Console.WriteLine("Podałeś nieprawidlowe dane. Sprobuj ponownie");
                    continue;
                }
                return day;
            }
        }

        private static int GetMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("Podałeś nieprawidlowe dane. Sprobuj ponownie");
                    continue;
                }
                return month;
            }
        }

        private static int GetYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year>DateTime.Now.Year)
                {
                    Console.WriteLine("Podałeś nieprawidlowe dane. Sprobuj ponownie");
                    continue;
                }
                return year;
            }
        }
    }
}
