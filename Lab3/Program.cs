namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver("Anton", 20, 2);
            Engine engine = new Engine(1500, "kto-to");
            Car car = new Car("nissan", 1, 1200, driver, engine);
            car.Start();
            car.TurnLeft();
            car.TurnRight();
            car.Stop();
            car.Show();
        }
    }
}

