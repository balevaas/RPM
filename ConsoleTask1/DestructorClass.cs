using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask1
{
    /// <summary>
    /// Класс с конструктором и деструктором
    /// </summary>
    internal class DestructorClass
    {
        private string name;    // закрытое текстовое поле

        /// <summary>
        /// Конструктор класса, может как создаваться автоматически,
        /// так и собственноручно
        /// </summary>
        /// <param name="txt"></param>
        public DestructorClass(string txt) 
        {
            name = txt;
            Console.WriteLine("Создан объект \"{0}\"", name);
        }

        /// <summary>
        /// Деструктор класса (удаляет объект из памяти)
        /// !!! Имя деструктора начинается с тильды ~, после которой указывается
        /// название класса.
        /// !!! Деструктор не возвращает рез-т, идентификатор типа рез-та для 
        /// него не указывается, также не указываются модификаторы доступа
        /// !!! У него нет аргументов и он не может быть перегружен 
        /// (в классе только один деструктор)
        /// </summary>
        ~DestructorClass()
        {
            Console.WriteLine("Объект удален \"{0}\"", name);
        }
    }
}
