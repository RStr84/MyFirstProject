using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MyFirstProject
{
    internal class Operators
    {

        public void StartOperators()
        {
            Console.WriteLine("Operators");
            Console.WriteLine();
        }

        public void StringAdd()
        {

            Console.WriteLine("Beispiel: Stringverkettung mit Addition");
            string name = "Raphael";
            Console.WriteLine($"Vorname: {name}");
            name += " Straschewski";
            Console.WriteLine($"Addition des Nachnamen ergibt: { name}");
            Console.WriteLine();
            /* Bei Addition von "char", also einzelnen Buchstaben, wird der ASCII-Wert (hexadezimal) addiert
            und das dazugehörige Zeichen des Unicodes ausgegeben. Strings subtrahieren ist dagegen nicht möglich*/

        }

        public void Add()
        {

            Console.WriteLine("Beispiel: Addition");
            int number = 40;
            Console.WriteLine($"Ausgangswert: {number}");
            number++;
            //number += 1;
            //number = number + 1;
            // Alle drei Varianten sind gleichwertig (jede Zeile addiert 1)
            Console.WriteLine($"Ausgangswert mit +Operator um 1 erhöht: {number}");
            Console.WriteLine();

        }

        public void Div()
        {

            Console.WriteLine("Beispiel: Division mit \"double\"");
            double number = 23;
            Console.WriteLine($"Ausgangswert: {number}");
            number /= 2;
            Console.WriteLine($"Division durch 2 ergibt: {number}");
            Console.WriteLine();

        }

        public void IncrementInCW()
        {

            Console.WriteLine("Beispiel: Inkremtierung in CW");
            int i = 0;
            int j = 0;
            Console.WriteLine($"Ausgangswerte i und j: 0");
            Console.WriteLine($"i++ ergibt: {i++}");
            Console.WriteLine($"++j ergibt: {++j}");
            Console.WriteLine("Ergebnis: i++ gibt den Wert vor der Erhöhung aus (0) und " +
                "++j gibt den Wert nach der Erhöhung aus (1)");
            Console.WriteLine();

        }

        /* Notizen
        % Modulo-Operator zur Bestimmung des Restwerts
        Bsp.: int number1 = 10 % 2 => 0;
              int number2 = 10 % 3 => 1;
        */

        


    }
}