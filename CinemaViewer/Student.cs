using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaViewer
{
    public class Student : Visitor
    {
        private double discount; // скидка
        public double Discount { get { return discount; } set { discount = value; } }
        public Student() : base()
        {
            ReadVisitor();
        }

        public override void Visit()
        {
            Console.WriteLine($"Наш кинотеант посетил студент {Name}." +
                $"\nКоличество посещений: {CountTicket}");
            double p = 0;
            Console.WriteLine("\n=================Чек=================");
            while (CountTicket > 0)
            {
                if (NumberVisition % 3 == 0)
                {
                    Discount = 0.5;
                    p += Price - (Price * Discount);
                    Console.WriteLine($"+ билет со скидкой 50%");
                    NumberVisition++;
                }
                else
                {
                    p += Price;
                    Console.WriteLine($"+ билет за полную стоимость");
                    NumberVisition++;
                }
                CountTicket--;
            }
            Console.WriteLine($"\nИтого к оплате: {p}");
        }
    }
}
