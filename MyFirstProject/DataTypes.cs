using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class DataTypes
    {
        public void TypeInteger() {

            Console.WriteLine("\"Integer -> Datentypbereiche\"");
            Console.WriteLine();

            int age = 40;                   // => Initialization und Declaration
            //int age = 50;                 // => Assignment
            //Console.WriteLine(age);
            Console.WriteLine("Datentypbereich für \"int\": " + int.MinValue + " bis " + int.MaxValue);

            long bigNumber = 900000000L;
            // Das L signalisiert eine Int64(Bit), sonst Int32(Bit) => nicht gleicher Datentypbereich
            //Console.WriteLine(bigNumber);
            Console.WriteLine("Datentypbereich für \"long\": " + long.MinValue + " bis " + long.MaxValue);

            double neagtive = 55.2D;
            // D steht für Double
            //Console.WriteLine(neagtive);
            Console.WriteLine("Datentypbereich für \"double\": " + double.MinValue + " bis " + double.MaxValue);

            float precision = 5.000001F;
            // F steht für Float; default ist D (double)
            //Console.WriteLine(precision);
            Console.WriteLine("Datentypbereich für \"float\": " + float.MinValue + " bis " + float.MaxValue);

            decimal money = 15.99M;
            // M steht für Decimal; default ist D (double)
            //Console.WriteLine(money);
            Console.WriteLine("Datentypbereich für \"decimal\": " + decimal.MinValue + " bis " + decimal.MaxValue);
            Console.WriteLine();

        }

        public void TypeTextBased()
        {
            Console.WriteLine("\"Textbasierte Datentypen\"");
            Console.WriteLine();

            string name = "Raphael";
            // "" bei mehreren Zeichen
            char letter = 'R';
            // '' bei einem Zeichen
            Console.WriteLine($"Dein Name lautet: {name}");
            Console.WriteLine();

        }

        public void ConvertStringToInt()
        {

            Console.WriteLine("\"Konvertierung String zu Int\"");
            Console.WriteLine();

            string textAge = "40";
            int convertedAge = Convert.ToInt32(textAge);
            Console.WriteLine($"Konvertiertes Alter \"int\": {convertedAge}");

            string textBigNumber = "-900000000";
            // Dateityp-Kennung L im String nicht erforderlich
            long convertedBigNumber = Convert.ToInt64(textBigNumber);
            // ToInt64 ist der Datentyp zu dem der String konvertiert werden soll
            Console.WriteLine($"Konvertierte BigNumber \"long\": {convertedBigNumber}");

            string textNeagtive = "-55.2";
            double convertedNegative = Convert.ToDouble(textNeagtive);
            Console.WriteLine($"Konvertierte negative Zahl \"double\": {convertedNegative}");
            
            string textPrecision = "5.000001";
            float convertedPrecision = Convert.ToSingle(textPrecision);
            Console.WriteLine($"Konvertierte positive Zahl \"float\": {convertedPrecision}");

            string textMoney = "15.99";
            decimal convertedMoney = Convert.ToDecimal(textMoney);
            Console.WriteLine($"Konvertierte Dezimalzahl \"decimal\": {convertedMoney}");
            Console.WriteLine();

        }

        public void TypeBoolean()
        {
            Console.WriteLine("\"Boolean\"");
            Console.WriteLine();

            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine($"Ist Wahr = Wahr?:   {isTrue}");
            Console.WriteLine($"Ist Wahr = Falsch?: {isFalse}");
            Console.WriteLine();
        }
    }
}
