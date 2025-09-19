using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shelf> shelfves = new List<Shelf>();
            new Shelf
            {
                Capacity = 10,
                ColumnNumber = 1,
                ShelfNumber = 2,
                Items = new List<Item>()
                { new Book{ Name="DinDey", IsForChildren=true, Price=50, Weight =20 },
                new Book{ Name="nh", IsForChildren=false, Price=100, Weight =30 }
                }

            };
            new Shelf
            {
                Capacity = 2,
                ColumnNumber = 2,
                ShelfNumber = 3,
                Items = new List<Item>()
                { new Book{ Name="DinDey", IsForChildren=true, Price=50, Weight =20 },
                new Book{ Name="nh", IsForChildren=false, Price=100, Weight =30 }
                }

            };

            var isFull =
                from Shelf in shelfves
                where Shelf.IsFull
                select Shelf;
            foreach (var shelf in isFull)
            {
                Console.WriteLine(shelf);
            }
            var isChild= 
                from shelf in shelfves
                where shelf.Items.OfType<Book>().Any(book=>book.IsForChildren)
                select shelf;
            foreach (var shelf in isChild)
            {
                Console.WriteLine(shelf) ;
            }
            var isExspensive = from shelf in shelfves
                               where shelf.Items.OfType<Book>().Any(book => book.IsExspensive)
                               select shelf;
            foreach(var shelf in isExspensive)
            {
                Console.WriteLine(shelf) ;
            }

        }

        }
    }
    
