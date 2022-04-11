using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Library
    {
        public List<Book> Books = new List<Book>();


        public List<Book> FilterByPrice(double minPrice,double maxPrice)
        {
            List<Book> newBook = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Price >=minPrice && item.Price <= maxPrice)
                {
                    newBook.Add(item);
                }
            }
            return newBook;
        }

        public List <Book> FilterByGenre(GenreType genre)
        {
            List<Book> newBook = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Genre ==genre)
                {
                    newBook.Add(item);
                }
            }
            return newBook;
        }

        public Book FindBookByNo(int no)
        {
            foreach (var book in Books)
            {
                var wantedBook = Books.Find(book => book.No == no);
                if (!String.IsNullOrWhiteSpace(wantedBook.Name))
                {
                    return book;
                }
                
            }
            return null;
        }

        public bool IsExistBookByNo(int no)
        {
            foreach (var book in Books)
            {
                if (Books.Exists(book=>book.No==no))
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveAll(Predicate <Book> predicate)
        {
            foreach (var book in Books)
            {
                if (predicate(book))
                {
                    Books.Remove(book);
                }
            }
        }
    }
}
