using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console ist Klasse aus "System"
            // cw + tab = Console.WriteLine(); 


            // Datatypes

            // Integer
            int age = 23;
            // int age = Initialisation
            // 23 = Deklaration
            Console.WriteLine(age);
            Console.WriteLine();
            Console.WriteLine("\"Datentypbereiche\"");
            Console.WriteLine("Datentypbereich für int: " + int.MinValue + " bis " + int.MaxValue);

            long bigNumber = 900000000L;
            // Das L signalisiert eine Int64(Bit), sonst Int32(Bit) => nicht gleicher Datentypbereich
            //Console.WriteLine(bigNumber);
            Console.WriteLine("Datentypbereich für long: " + long.MinValue + " bis " + long.MaxValue);

            double neagtive = 55.2D;
            // D steht für Double
            Console.WriteLine(neagtive);
            Console.WriteLine("Datentypbereich für double: " + double.MinValue + " bis " + double.MaxValue);

            float precision = 5.000001F;
            // F steht für Float; default ist D (double)
            Console.WriteLine(precision);
            Console.WriteLine("Datentypbereich für float: " + float.MinValue + " bis " + float.MaxValue);





        }
    }
}
