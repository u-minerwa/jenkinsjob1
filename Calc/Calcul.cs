using System;

namespace Calc
{
    public class Calcul
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            var oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите первое число:");
            var b = Convert.ToDouble(Console.ReadLine());

            Compute(a,b,oper);
        }

        public static double Compute (double a,double b, char oper)
        {
        
            double total;
            
            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total + ".");
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
                throw new Exception("Неизвестный оператор");
            }
            return total;
        }
    }
}
