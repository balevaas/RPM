using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    public class Book
    {
        private string nameBook;
        private string authotBook;

        public string NameBook { get => nameBook; set => nameBook = value; }
        public string AuthotBook { get => authotBook; set => authotBook = value; }
        public Book() { }
        public Book(string nameBook, string authotBook)
        {
            NameBook = nameBook;
            AuthotBook = authotBook;
        }
    }
}
