using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask1
{
    public class StaticClass
    {
        public static int code = 100; // Статическое поле
        public static void Show() // Статический метод
        {
            Console.WriteLine("Статическое поле: " + code);
        }

        public const double pi = 3.14592;

        private static int n = 100;

        public static double exp(double x)
        {
            double s = 0, q = 1;
            for(int i = 0; i < n; i++) 
            {
                s += q;
                q *= x/(i + 1);
            }
            return s;
        }

        public static double Sin(double x)
        {
            double s = 0, q = x;
            for(int i = 0; i <= n; i++)
            {
                s += q;
                q *= (-1) * x * x / (2 * i + 2) / (2 * i + 3);
            }
            return s;
        }
    }
}
