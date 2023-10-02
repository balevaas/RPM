using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaViewer
{
    public class Regular : Visitor
    {
        // Дополнительные закрытые поля
        private double discount;    // скидка
        private int num;            // для определения размера скидки
                                    // исходя из кол-ва билетов
        // свойство для поля скидки
        public double Discount { get { return discount; } set { discount = value; } }
        
        /// <summary>
        /// Конструктор класса
        /// вызывающий метод из главного класса 
        /// </summary>
        public Regular() : base()
        {
            ReadVisitor(); // метод считывания с клавиатуры
        }

        /// <summary>
        /// Переопределенный метод для высчитывания скидки и итоговой суммы
        /// </summary>
        public override void Visit()
        {
            Console.WriteLine($"Наш кинотеант посетил постоянный клиент {Name}." +
                $"\nКоличество посещений: {CountTicket}");
            double p = 0;
            Console.WriteLine("\n=================Чек=================");
            while (CountTicket > 0)
            {
                if (NumberVisition >= 10 && NumberVisition < 30)
                {
                    num = NumberVisition / 10 % 10;
                    switch (num)
                    {
                        case 1:
                            Discount = 0.05;
                            p += Price - (Price * Discount);
                            Console.WriteLine($"+ билет со скидкой 5%");
                            NumberVisition++;
                            break;
                        case 2:
                            Discount = 0.1;
                            p += Price - (Price * Discount);
                            NumberVisition++;
                            Console.WriteLine($"+ билет со скидкой 10%");
                            break;
                    }
                }
                else if(NumberVisition > 29)
                {
                    Discount = 0.2;
                    p += Price - (Price * Discount);
                    NumberVisition++;
                    Console.WriteLine($"+ билет со скидкой 20%");
                }
                else Console.WriteLine("Error");
                CountTicket--;
            }
            Console.WriteLine($"\nИтого к оплате: {p}");
        }
    }
}
