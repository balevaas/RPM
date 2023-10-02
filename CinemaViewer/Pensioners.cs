using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaViewer
{
    public class Pensioners : Visitor
    {
        private double discount;
        public double Discount { get { return discount; } set { discount = value; } }
        public Pensioners() : base()
        {
            ReadVisitor();
        }

        public override void Visit()
        {
            Console.WriteLine($"Наш кинотеант посетил пенсионер {Name}." +
                $"\nКоличество посещений: {CountTicket}");
            double p = 0;
            Console.WriteLine("\n=================Чек=================");
            while(CountTicket > 0)
            {
                if(NumberVisition % 5 == 0)
                {
                    Discount = 1;
                    p += Price - (Price * Discount);
                    Console.WriteLine($"+ один билет с полной скидкой");
                    NumberVisition++;
                }
                else
                {
                    Discount = 0.5;
                    p += Price - (Price * Discount);
                    Console.WriteLine($"+ один билет со скидкой 50%"); ;
                    NumberVisition++;
                }
                CountTicket--;
            }
            Console.WriteLine($"\nИтого к оплате: {p}");
        }
    }
}
