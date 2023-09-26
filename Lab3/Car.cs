using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBaza
{
    public class Car
    {
        private string brand;
        private int classCar;
        private double ves;
        private Driver driver;
        private Engine engine;

        public string Brand { get { return brand; } set {  brand = value; } }
        public int ClassCar { get {  return classCar; } set {  classCar = value; } }
        public double Velocity { get {  return ves; } set {  ves = value; } }
        public Driver Driver { get { return driver; } set { driver = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }

        public Car(string brand, int classCar, double ves, Driver driver, Engine engine)
        {
            this.brand = brand;
            this.classCar = classCar;
            this.ves = ves;
            this.driver = driver;
            this.engine = engine;
        }

        public void Start() { Console.WriteLine("Поехали"); }
        public void Stop() { Console.WriteLine("Останавливаемся"); }
        public void TurnRight() { Console.WriteLine("Поворот направо"); }
        public void TurnLeft() { Console.WriteLine("Поворот налево"); }

        public void Show()
        {
            Console.WriteLine($"{Brand}, {ClassCar}, {Velocity}");
            Driver.Show();
            Engine.Show();
        }
    }
}
