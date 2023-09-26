using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTaskSamRab
{
    public class MyClass
    {
        private char symb;

        public char Symb { get { return symb; } set {  symb = value; } }

        public MyClass(char s) { s = symb; }
        public void Show()
        {
            Console.WriteLine(Symb + " " +  Symb.ToString());
        }
    }
}
