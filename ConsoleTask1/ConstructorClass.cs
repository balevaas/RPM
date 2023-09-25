using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask1
{
    /// <summary>
    /// Описание класса с конструкторами
    /// </summary>
    internal class ConstructorClass
    {
        // Закрытые поля:
        public int num;     // Целочисленное поле
        public char symb;   // Символьное поле
        public string txt;  // Текстовое поле


        // Открытый метод для отображения значений полей:
        public void Show()
        {
            Console.WriteLine("Поля: {0}, \'{1}\' и \"{2}\"", num, symb, txt);
        }

        // Конструктор по умолчанию:
        public ConstructorClass() 
        {
            num = 100;
            symb = 'A';
            txt = "text field 1";
        }

        // Конструктор с одним целочисленным параметром:
        public ConstructorClass(int n)
        {
            num = n;
            symb = 'B';
            txt = "text field 2";
        }

        // Конструктор с двумя параметрами
        public ConstructorClass(int n, char c)
        {
            num = n;
            symb = c;
            txt = "text field 3";
        }

        // Конструктор с тремя параметрами
        public ConstructorClass(int n, char c, string s)
        {
            num = n;
            symb = c;
            txt = s;
        }

        // Конструктор с одним текстовым аргументом
        public ConstructorClass(string s)
        {
            num = 0;
            symb = 'Z';
            txt = s;
        }

    }
}
