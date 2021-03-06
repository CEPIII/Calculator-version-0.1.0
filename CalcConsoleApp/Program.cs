﻿using System;
using Pack.Clc;
using static System.Console;
using static Pack.Clc.OutputMessage;

namespace CalcConsoleApp
{    
    class Program
    {
        public static decimal total ;

        static void Main(string[] args)
        {
            Console.WriteLine("en: Console Calculator version 0.1.0 welcomes you!\n" +
                "ru: Консольный калькулятор версии 0.1.0 приветствует вас!\n");

            Info.info();        //  выводит справку



            string exit = "exit";
            bool boolInput;
            string tempStr;
            do
            {   //Ввести самое первое число
                Write("Enter a number (введите число): ");
                tempStr = ReadLine();
                decimal num;
                boolInput = decimal.TryParse(tempStr, out num);
                if (boolInput)
                {
                    total = num;
                }
                else
                {
                    InvalidInput();
                    //WriteLine("Invalid input. (Не корректный ввод.)\n");
                }
            } while (!boolInput);
            tempStr = "";
            boolInput = false;


            // нужно ввести оператор и далее выполнить соответствующее действие

            do
            {
                WriteLine("\nВведите 'exit' для завершения приложения, либо");
                Write("Enter a operator (введите оператор +,-,*,/): ");
                tempStr = ReadLine();
                switch (tempStr)
                {
                    case "+":
                        total = Funktion.Summ(total);
                        break;
                    case "-":
                        total = Funktion.Subtraction(total);
                        break;
                    case "*":
                        total = Funktion.Multiplication(total);
                        break;
                    case "/":
                        total = Funktion.Division(total);
                        break;
                    default:
                        WriteLine("\nВведенное значение не является оператором");
                        if (tempStr == exit) 
                        { 
                            WriteLine("Вы ввели 'exit'"); 
                        }
                            WriteLine($"Результат всех вычеслениий total = {total}\n");                          
                        break;

                }
            } while (tempStr != exit);

            //WriteLine($"total = {total}");


            
            
        }
    }
}
