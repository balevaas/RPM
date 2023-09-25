namespace ConsoleTask1
{
    // Класс с главным методом
    internal class Program
    {
        // Главный метод
        static void Main(string[] args)
        {
            // Вызов методов для проверки работы различных классов
            Constructor();
            Console.WriteLine();
            Destructor();
        }

        /// <summary>
        /// Метод для тестра работы класса ConstructorClass
        /// </summary>
        static void Constructor()
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
        static void Destructor()
        {
            DestructorClass destructorClass1 = new DestructorClass("Первый");
            new DestructorClass("Второй");
            destructorClass1 = new DestructorClass("Третий");
            
        }
    }
}