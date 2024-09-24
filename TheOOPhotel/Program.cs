using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheOOPhotel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var (name, age, day, startDate, endDate) = Userinput();

            hotelbooking people = new hotelbooking(name, age, day, startDate, endDate);

            Console.WriteLine($"Ditt namn är {name} och du ska stanna hos oss {startDate.ToShortDateString()} tills {endDate.ToShortDateString()} i totalt {day} dagar!");


            Console.ReadLine();
        }
        public static (string, int, int, DateTime, DateTime) Userinput() 
        {
            Console.WriteLine("Hejsan! Välkommen till denna hotell!");

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange bokningsdatum YYYY MM DD");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                
            Console.WriteLine("Hur många dagar vill du stanna?");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime endDate = startDate.AddDays(day);
            return (name, age, day, startDate, endDate);   
        }

 
    }

}
