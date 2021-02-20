using System;
using Pack.Clc;
using static System.Console;

namespace CalcConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("en: Console Calculator version 1.0 welcomes you!\n" +
                "ru: Консольный калькулятор версии 1.0 приветствует вас!\n");

            WriteLine("Для вычислений воспользуйтесь цифрами на клавиатуре от 0 до 9\n" +
                "For calculations, use the numbers on the keyboard from 0 to 9\n\n" +
                "and calculation operators:\n" +
                "и еператорами вычислений:\n\n");
            WriteLine("'+' - addition\t\t(сложение)\n" +
                "'-' - subtraction\t(вычитание)\n" +
                "'/' - division\t\t(деление)\n" +
                "'*' - multiplication\t(умножение)\n" +
                "'%' - percent\t\t(процент)");
        }
    }
}
