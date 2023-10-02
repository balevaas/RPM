using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaViewer
{
    public class Viewer : Visitor
    { 
        public Viewer() : base()
        {
            ReadVisitor();
        }

        public override void Visit()
        {
            Console.WriteLine($"Наш кинотеант посетил новый клиент {Name}." +
                $"\nКоличество посещений: {CountTicket}");
            Console.WriteLine("\n=================Чек=================");
            NumberVisition++;
            if(CountTicket > 1) Console.WriteLine($"\nИтого к оплате: {Price * CountTicket}");
            else Console.WriteLine($"\nИтого к оплате: {Price}");

        }
    }
}
