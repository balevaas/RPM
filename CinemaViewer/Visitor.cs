using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaViewer
{
    public abstract class Visitor
    {
        // закрытые поля 
        private string name;            // имя
        private int numberVisition;     // количество посещений
        private double price;           // стоимость билета
        private int countTicket;        // количество билетов
        
        // Свойства для полей
        public string Name { get { return name; } set { name = value; } }
        public int NumberVisition { get { return numberVisition; } set { numberVisition = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int CountTicket { get { return countTicket; } set { countTicket = value; } }

        /// <summary>
        /// Метод для ввода с клавиатуры данных
        /// </summary>
        public void ReadVisitor()
        {
            Console.Write("\nВведите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите количество посещений: ");
            numberVisition = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость билета: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Введите количество билетов: ");
            countTicket = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        /// <summary>
        /// Абстрактный метод высчитывающий стоимость билета
        /// </summary>
        public abstract void Visit();
    
    }
}
