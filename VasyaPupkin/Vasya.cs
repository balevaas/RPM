using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasyaPupkin
{
    public class SupriseMe
    {
        public static void RunMe()
        {
            Vasya vasya = new Vasya("Василий", 5);
            Vasya petya = new Vasya("Петя", 123);
            vasya.Print();
            petya.Print();
        }
    }

    public class Vasya
    {
        private string name;
        private int age;
        private string ageText;

        public string Name
        {
            get => name;
            set
            {
                if(value != "Василий")
                {
                    name = $"Я не {value}, а Вася!";
                }
                else name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0) age = 0;
                else if (value > 122) age = 122;
                else age = value;
            }
        }

        public Vasya(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine(Name);
            AgeText();
            Console.WriteLine("Мне " + Age + ageText);
        }

        private string AgeText()
        {
            int t1 = Age % 10;
            int t2 = Age % 100;
            if (t1 == 1 && t2 != 11) ageText = " год"; 
            if (t1 >= 2 && t1 <= 4 && (t2 < 10 || t2 >= 20)) ageText = " года";
            else ageText = " лет";
            return ageText;
        }
    }
}
