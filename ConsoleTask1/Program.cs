namespace ConsoleTask1
{
    // Класс с главным методом
    internal class Program
    {
        // Главный метод
        static void Main(string[] args)
        {
            // Вызов методов для проверки работы различных классов
            Program p = new Program();
            p.Constructor();
            Console.WriteLine();
            p.Destructor();
            Console.WriteLine();
            p.Static();
            Console.WriteLine();
            p.This();
        }

        /// <summary>
        /// Метод для тестра работы класса ConstructorClass
        /// </summary>
        void Constructor()
        {
            // Создание объектов
            // Вызывается конструктор по умолчанию:
            ConstructorClass constructClass1 = new ConstructorClass();

            // Проверяется значение полей объекта:
            constructClass1.Show();

            // Вызывается конструктор с целочисленным параметром: 
            ConstructorClass constructClass2 = new ConstructorClass(200);
            // Проверяется значение полей объекта:
            constructClass2.Show();

            // Вызывается конструктор с двумя параметрами:
            ConstructorClass constructClass3 = new ConstructorClass(300, 'C');
            // Проверяется значение полей объекта:
            constructClass3.Show();

            // Вызывается конструктор с тремя параметрами:
            ConstructorClass constructClass4 = new ConstructorClass(400, 'D', "text field 4");
            // Проверяется значение полей объекта:
            constructClass4.Show();

            // Вызывается конструктор с символьным параметром:
            ConstructorClass constructClass5 = new ConstructorClass('A');
            // Проверяется значение полей объекта:
            constructClass5.Show();

            // Вызывается конструктор с текстовым параметром:
            ConstructorClass constructClass6 = new ConstructorClass("Text field 5");
            // Проверяется значение полей объекта:
            constructClass6.Show();
        }

        /// <summary>
        /// Метод для теста работы класса DestructorClass
        /// </summary>
        void Destructor()
        {
            DestructorClass destructorClass1 = new DestructorClass("Первый");
            new DestructorClass("Второй"); // анонимный экземпляр
            destructorClass1 = new DestructorClass("Третий");
            Maker("Четвертый"); // анонимный экземпляр
            destructorClass1 = new DestructorClass("Пятый");            
        }

        /// <summary>
        /// Метод для создания анонимного экземпляра класса
        /// </summary>
        /// <param name="txt"></param>
        void Maker(string txt)
        {
            new DestructorClass(txt);
        }

        /// <summary>
        /// Метод для теста работы класса StaticClass
        /// </summary>
        void Static()
        {
            // Отличие статичных методов от обычных в том, что не нужно создавать экземпляр класса
            // и через него обращаться к методам.
            // Достаточно, просто написать название класса и через . вызвать нужный метод
            StaticClass.Show();     // вызов статичного метода
            StaticClass.code = 200; // переприсвоение значения в статичном поле
            StaticClass.Show();     // снова вызов метода
            Console.WriteLine();

            double z = 1; // объявляем переменную 
            Console.WriteLine("exp({0}) = {1}", z, StaticClass.exp(z));     // при выводе на экран, вызываем статичный метод класса для вычисления экспоненты
            Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));    // проверяем работу метода, с помощью встроенного класса Math 
            z = StaticClass.pi/4;                                           // присваиваем переменной Z, значение из класса (константу делим на 4) 
            Console.WriteLine("sin({0}) = {1}", z, StaticClass.Sin(z));     // вызываем метод вычисления синуса из класса
            Console.WriteLine("Контрольное значение: {0}", Math.Sin(z));    // проверяем работу метода, с помощью встроенного класса Math
        }

        void This()
        {
            ThisClass thisClass1 = new ThisClass(100);
            Console.WriteLine();
            ThisClass thisClass2 = new ThisClass(200, 300);
            Console.WriteLine();
            ThisClass thisClass3 = new ThisClass();
        }
    }
}