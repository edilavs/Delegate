using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Book
    {
        public Book()
        {
            _totalcount++;
            No = _totalcount;
        }
        static int _totalcount;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }

        public GenreType Genre { get; set; }
        public double Price { get; set; }

    }
}
