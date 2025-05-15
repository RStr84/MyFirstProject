using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class IfElseSwitchCase
    {

        public void IfElse()
        {

            Console.WriteLine("\"If/Else Name&Alter\"");
            Console.Write("Wie ist dein Name? ");
            string name = Console.ReadLine();
            Console.Write("Wie alt bist du? ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            // Console.ReadLine() gibt immer einen String zurück, daher muss dieser konvertiert werden
            // int age = Convert.ToInt32(Console.ReadLine()); Variante als Einzeiler
            Console.WriteLine($"Dein Name lautet {name} und du bist {age} Jahre alt!");
            // ==, !=, >, <, >=, <=, || (or), && (and)
            if (age < 0 || age > 120)
            {
                Console.WriteLine("Ungültiges Alter!");
            }
            else
            {
                if (age >= 18)
                {
                    Console.WriteLine("Du bist volljährig!");
                }
                else
                {
                    Console.WriteLine("Du bist minderjährig!");
                }
            }
            Console.WriteLine();
            Thread.Sleep(3000);
            // Thread.Sleep(3000) = 3 Sekunden warten

        }

        public void Calculator()
        {
            Console.WriteLine("\"If/Else Taschenrechner\"");
            
            Console.Write("Gib eine Zahl ein: ");
            string num1Input = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Input);
            Console.Write("Gib eine Zahl ein: ");
            string num2Input = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Input);
            Console.Write("Gib einen mathematischen Operator ein! ");
            string operatorInput = Console.ReadLine();

            if (operatorInput == "+")
            {
                int result = num1 + num2;
                Console.WriteLine($"Das Ergebnis ist: {result}");
            }
            else if (operatorInput == "-")
            {
                int result = num1 - num2;
                Console.WriteLine($"Das Ergebnis ist: {result}");
            }
            else if (operatorInput == "*")
            {
                int result = num1 * num2;
                Console.WriteLine($"Das Ergebnis ist: {result}");
            }
            else if (operatorInput == "/")
            {
                if (num2 != 0)
                {
                    double result = (double)num1 / num2;
                    // Casten von int zu double, damit die Division präziser ist (z.B. 5/2 = 2.5) und nicht 2 (bei "int" wird abgerundet)
                    Console.WriteLine($"Das Ergebnis ist: {result}");
                }
                else
                {
                    Console.WriteLine("Division durch Null ist nicht erlaubt!");
                }
            }
            else
            {
                Console.WriteLine("Ungültiger Operator!");
            }
        }

        public void Switch()
        {
            Console.WriteLine("\"Switch/Case\"");
            Console.WriteLine();










        }




    }
}
