using System;
using static System.Console;
using static Pack.Clc.OutputMessage;

namespace Pack.Clc
{
    public static class Funktion
    {
/*
        public static void EnterNumber()
        {
            Write("Enter a number (введите число): ");
            string tempStr = ReadLine();
            decimal num;
            if (decimal.TryParse(tempStr, out num))
            {
                total = num;
                
            }
            else
            {
                WriteLine("Invalid input. Enter a number. (Не корректный ввод. Введите число.)");
                
            }
*/
        public static decimal Summ(decimal tota1)
        {
            bool boolNum = false;
            decimal total = tota1;
            decimal inputDec;
            do
            {
                WriteLine("\nВведите числовое значение");
                string tempStr = ReadLine();
                
                boolNum = decimal.TryParse(tempStr, out inputDec);
                if (boolNum)
                {                    
                    total += inputDec;
                }
                else
                {
                    InvalidInput();
                }
            } while (!boolNum);

            WriteLine($"Результат вычеслений Result = {total}");
            return total;
            
        }

        public static decimal Subtraction(decimal tota1)
        {
            decimal inputDec = 0;
            return tota1 - inputDec;
        }

        public static decimal Multiplication(decimal tota1)
        {
            decimal inputDec = 0;
            return tota1 * inputDec;
        }

        public static decimal Division(decimal tota1)
        {
            decimal inputDec = 0;
            return tota1 / inputDec;
        }
    }
}
