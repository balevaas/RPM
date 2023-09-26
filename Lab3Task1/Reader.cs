using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    public class Reader
    {
        private string person;
        private int numberBilet;
        private string facultet;
        private string dateBorn;
        private int numberPhone;

        public string Person { get => person; set => person = value; }
        public int NumberBilet { get => numberBilet; set => numberBilet = value; }
        public string Facultet { get => facultet; set => facultet = value; }
        public int NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string DateBorn { get => dateBorn; set => dateBorn = value; }

        public Reader(string person, int numberBilet, string facultet, string dateBorn, int numberPhone)
        {
            Person = person;
            NumberBilet = numberBilet;
            Facultet = facultet;
            DateBorn = dateBorn;
            NumberPhone = numberPhone;
        }

        public Reader() { }

        public void TakeBook(string person, int countBook)
        {
            Console.WriteLine($"{person} взял/а книги в количестве {countBook} штук/а");
        }

        public void TakeBook(string person, string book1, string book2, string book3)
        {
            Console.WriteLine($"{person} взял/а книги {book1}, {book2}, {book3}");
        }

        public void TakeBook(Reader person, Book[] book)
        {
            Console.WriteLine($"{person} взял/а книги: ");
            for(int i = 0; i < book.Length; i++)
            {
                Console.WriteLine(book[i] + " ");
            }
        }




    }
}
