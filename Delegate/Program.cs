using Models;
using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elave olunacaq kitablarin sayini daxil edin:");
            int count = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kitab janrlarinin sayini daxil edin:");
            //int genreCount = int.Parse(Console.ReadLine());
            Book book = new Book();
            List<Book> Books = new List<Book>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}.ci kitabin adi:");
                string name = Console.ReadLine();
                Console.WriteLine("Kitabin Muellif adi:");
                string authorName = Console.ReadLine();
                Console.WriteLine("Kitabin qiymeti:");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Kitabin janri:");
                book.Name = name;
                book.AuthorName = authorName;
                book.Price = price;

                Books.Add(book);
            }
            foreach (var item in Books)
            {
                Console.WriteLine(item.Name+" "+item.AuthorName +" "+item.Genre);
            }

            Library library =new Library();
          
            foreach (var item in library.FilterByPrice(30, 100))
            {
                Console.WriteLine(item);
            }
        }
    }
}
