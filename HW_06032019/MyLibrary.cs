using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_06032019
{
    class MyLibrary
    {
        Dictionary<string, Book> _books;

        public MyLibrary()
        {
            _books = new Dictionary<string, Book>();
        }
        public bool AddBook(Book b)
        {
           if(_books.ContainsKey(b.Title))
            return false;
            _books.Add(b.Title, b);
            return true;
        }
        public bool RemoveBook(string title)
        {
            if(!_books.ContainsKey(title))
            return false;

            _books.Remove(title);
            return true;
          
        } 
        public bool HaveThisBook(string title)
        {
            if (!_books.ContainsKey(title))
                return false;
            return true;
        }
        public Book GetBook(string title )
        {
            if (!_books.ContainsKey(title))
                return null;
            return _books[title];
        }
        public Book GetByAuthor(string author)
        {
            // option 1
            foreach(KeyValuePair<string, Book > pair in _books)
            {
                if (pair.Value.Author == author)
                    return pair.Value;
            }
            return null;

            //option 2
            foreach(Book book in _books.Values)
            {
                if (book.Author == author)
                    return book;
            }
            return null;

        }
        public void Clear()
        {
            _books.Clear();
        }
        public List<string> GetAuthors()
        {
            List<string> autors = new List<string>();
            foreach(Book book in _books.Values)
            {
                autors.Add(book.Author);
            }
            return autors;
        }
        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> books = new List<Book>();

            foreach(Book book in _books.Values)
            {
                books.Add(book);
            }
            books.Sort();

            return books;
            
        }
        public List<string> GetBooksTitleSordet()
        {
            List<string> titles = new List<string>();

            foreach (Book book in _books.Values)
            {
                titles.Add(book.Title);
            }
            titles.Sort();

            return titles;

        }
        public int Count
        {
             get
             {
                return _books.Count;
             }
        }

        public override string ToString()
        {
            string result = $"My Library: {Count} books \n"; 
            foreach(KeyValuePair<string, Book> pair in _books)
            {
                result += $"[Key: {pair.Key}]\n{pair.Value} \n";
            }
            return result;
        }
    }
}
