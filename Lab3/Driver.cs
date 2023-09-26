using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBaza
{
    public class Driver : Person
    {
        private int stash;
        public int Stash 
        { 
            get { return stash; } 
            set 
            {
                stash = value;
            } 
        }
        public Driver(string name, int age, int stash) : base(name, age)
        {
            this.stash = stash;
        }

        public void Show()
        {
            Console.WriteLine($"Водитель {Name}, {Age} лет, стаж: {Stash}");
        }

    }
}
