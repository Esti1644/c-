using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls2
{

    public class Book : Item

    {
        public int weight { get; set; }
        public string author { get; set; }
        public Book(string name, int price, int count, int age, string author, int weight) : base(name, price, count, age,capacity)
        {
            this.author = author;
            this.weight = weight;
        }



        public override string ToString()
        {
            return base.ToString() + "author:" + author;
        }
        public List<Book> Items = new List<Book>();
        public double TotalWeight()
        {
            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.weight;
            }
            return sum;
        }
        public bool IsFull()
        {
            return TotalWeight() >= capacity;
        }


    }
}