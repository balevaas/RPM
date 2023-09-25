using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Engine
    {
        private int moshnost;
        private string proizvoditel;
        public int Moshnost { get {  return moshnost; } set {  moshnost = value; } }
        public string Proizvoditel { get {  return proizvoditel; } set {  proizvoditel = value; } }

        public Engine(int mosh, string proiz) 
        {
            moshnost = mosh;
            proizvoditel = proiz;
        }

        public void Show()
        {
            Console.WriteLine($"{Proizvoditel}, мощность: {Moshnost}");
        }
    }
}
