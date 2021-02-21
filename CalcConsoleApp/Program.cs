using System;
using Pack.Clc;
using static System.Console;


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




            bool boolInput;
            do
            {   //Ввести самое первое число
                Write("Enter a number (введите число): ");
                string tempStr = ReadLine();
                decimal num;
                boolInput = decimal.TryParse(tempStr, out num);
                if (boolInput)
                {
                    total = num;
                }
                else
                {
                    WriteLine("Invalid input. (Не корректный ввод.)\n");
                }
            } while (!boolInput);

            WriteLine($"total = {total}");
            
            
        }
    }
}
