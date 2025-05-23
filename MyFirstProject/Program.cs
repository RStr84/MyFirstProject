﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;
using System.Threading;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            // Setzt die aktuelle Kultur auf Englisch (USA)
            // Wichtig bei Punkt + Komma

            Console.WriteLine("C# und Visual Studio 2022!");
            Console.WriteLine();
            // Console ist Klasse aus "System"
            // cw + tab = Console.WriteLine(); 
            // Auskommentieren = strg + #

            // Datatypes
            Console.WriteLine("Datatypes");
            Console.WriteLine();
            DataTypes intType = new DataTypes();
            intType.TypeInteger();
            //DataTypes textType = new DataTypes();
            //textType.TypeTextBased();
            DataTypes conStToInt = new DataTypes();
            conStToInt.ConvertStringToInt();
            DataTypes boolType = new DataTypes();
            boolType.TypeBoolean();

            // Operators
            Console.WriteLine("Operators");
            Console.WriteLine();
            Operators addNumber = new Operators();
            addNumber.Add();
            Operators divNumber = new Operators();
            divNumber.Div();
            Operators stringAdd = new Operators();
            stringAdd.StringAdd();
            Operators increment = new Operators();
            increment.IncrementInCW();
            Operators modulo = new Operators();
            modulo.Modulo();

            // IfElseSwitchCase
            Console.WriteLine("If/Else & Switch/Case");
            Console.WriteLine();
            IfElseSwitchCase ifElse = new IfElseSwitchCase();
            ifElse.IfElse();
            IfElseSwitchCase calculator = new IfElseSwitchCase();
            calculator.Calculator();
            IfElseSwitchCase switchCase = new IfElseSwitchCase();







        }
    }
}
