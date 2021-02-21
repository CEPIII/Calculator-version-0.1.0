using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pack.Clc
{
    public class Info
    {
        public static void info()       //  справка по используемым клавишам
        {
            WriteLine("Для вычислений воспользуйтесь цифрами на клавиатуре от 0 до 9\n" +
                       "For calculations, use the numbers on the keyboard from 0 to 9\n\n" +
                       "and calculation operators:\n" +
                       "и еператорами вычислений:\n\n");
            WriteLine("'+' - addition\t\t(сложение)\n" +
                "'-' - subtraction\t(вычитание)\n" +
                "'/' - division\t\t(деление)\n" +
                "'*' - multiplication\t(умножение)\n" +
                "'%' - percent\t\t(процент) можно добавлять со второго вводимого значения (например 10%)\n" +
                "\n" +
                "the 'enter' key completes the input (клавиша 'enter' завершает ввод)");

            WriteLine("\n'exit' - to exit the app (для выхода из приложения)\n");
        }


    }
}
