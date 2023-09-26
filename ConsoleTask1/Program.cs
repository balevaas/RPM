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
            StaticClass.Show();
            StaticClass.code = 200;
            StaticClass.Show();

            double z = 1;
            Console.WriteLine("exp({0}) = {1}", z, StaticClass.exp(z));
            Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));
            z = StaticClass.pi/4;
            Console.WriteLine("sin({0}) = {1}", z, StaticClass.Sin(z));
            Console.WriteLine("Контрольное значение: {0}", Math.Sin(z));
        }


    }
}