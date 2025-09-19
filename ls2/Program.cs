using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls2
{
    internal class Program
    {
        


        static void Main(string[] args)
            {
             List<Shelf<Book>> bookshelf = new List<Shelf<Book>>();
            //Shelf<Book> shelf1;
            //Shelf<Book> shelf2;
            Book book1 = new Book(name: "platzebo", price:24,count: 65, age:40,author: "ester",weight:7);
            Book book2= new  Book(name: "fadael", price: 79, count: 20, age: 60, author: "mayah", weight: 10);
            Book book3 = new Book(name: "worldNice", price: 35, count: 10, age: 40, author: "moshe", weight: 3);
           
            Shelf<Book> shelf1 = new Shelf<Book>(numberShelf:1,couls:5,mishkal:300);
            Shelf<Book> shelf2 = new Shelf<Book>(numberShelf:2,couls:7,mishkal:500);
          

            shelf1.Add(book1);
            shelf2.add(book2);
            shelf2.add(book3);
            bookshelf.Add(shelf2);
            bookshelf.Add(shelf1);

            var shelfFull = (from item in bookshelf
                             where item.IsFull()
                             select item).ToList();

            Console.WriteLine("מדפים מלאים:");


           
            

            var shelfChild = (from item in bookshelf
                              where item.book.age < 11
                              select item).ToList();
            Console.WriteLine("ספרים לילדים");
            foreach(var s in shelfChild)
                Console.WriteLine(s);
            Console.WriteLine("מדפים עם ספרים יקרים");

            var shelfExpensive = (from item in bookshelf
                                  where item.shelf.book.price > 50
                                  select item).ToList();
            foreach (var expen in shelfExpensive)
                Console.WriteLine(expen);

            //לאיזה ספרים צריך ךערוך הזמנה נוספת
            var bookNeedInvite = (from item in bookshelf
                                  //where item.shelf.book.count < 7
                                  where item.count < 7
                                  select item).ToList();
            Console.WriteLine("צריך לערוך הזמנה נוספת לספרים");                
            foreach(var i in bookNeedInvite)
                Console.WriteLine(i);
        }
    }
    }

