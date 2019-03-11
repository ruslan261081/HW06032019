using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06032019
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary library = new MyLibrary();

            library.AddBook(new Book("Harry Potter", "But I haven't gotten any messages. From any of my...",

                "J.K. Rowling", "Fiction"));
            library.AddBook(

                new Book("War and Peace", "But mon cher ami, how can you be so calm? This monster, Bonaparte, he's crossed into Austria now, and who's to say that Russia won't be next? No, no, no...",

                "LEO TOLSTOY", "History"));

            Console.WriteLine(library);

        }
    }
}
