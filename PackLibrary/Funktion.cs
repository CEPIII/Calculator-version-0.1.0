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
                    total-= inputDec;
                }
                else
                {
                    InvalidInput();
                }
            } while (!boolNum);

            WriteLine($"Результат вычеслений Result = {total}");
            return total;
        }

        public static decimal Multiplication(decimal tota1)
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
                    total*= inputDec;
                }
                else
                {
                    InvalidInput();
                }
            } while (!boolNum);

            WriteLine($"Результат вычеслений Result = {total}");
            return total;
        }

        public static decimal Division(decimal tota1)
        {
            bool boolNum = false;
            decimal total = tota1;
            decimal inputDec;
            do
            {
                WriteLine("\nВведите числовое значение");
                string tempStr = ReadLine();

                boolNum = decimal.TryParse(tempStr, out inputDec);
                if (boolNum && inputDec != 0)
                {
                    total/= inputDec;
                }
                else
                {
                    if(inputDec == 0)
                    {
                        WriteLine("\nНа ноль делить нельзя, введите другое число");
                    }
                    InvalidInput();
                }
            } while (!boolNum || inputDec == 0);

            WriteLine($"Результат вычеслений Result = {total}");
            return total;
        }
    }
}
