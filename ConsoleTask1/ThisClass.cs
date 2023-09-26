using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask1
{
    internal class ThisClass
    {
        public int alpha;
        public int bravo;

        public ThisClass(int a)
        {
            Console.WriteLine("Конструктор с одним параметром");
            alpha = a;
            bravo = alpha;
            Console.WriteLine("Оба поля равны " + alpha);
        }

        public ThisClass(int a, int b) : this(a) 
        {
            Console.WriteLine("Конструктор с двумя параметрами");
            bravo = b;
            Console.WriteLine("Поля " + alpha + " и " + bravo);
        }

        public ThisClass() : this(400,500) 
        {
            Console.WriteLine("Конструктор без параметров");
            Console.WriteLine("Значения " + alpha + " и " + bravo);
        }

    }
}
