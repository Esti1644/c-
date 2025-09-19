using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls2
{
    public class Item
    {
        public string name { get; set; }
        public int price { get; set; }
        public int count { get; set; }
        public int age { get; set; }
        public double capacity { get; set; }

        public Item(string name, int price, int count, int age,double capacity)
        {
            this.name = name;
            this.price = price;
            this.count = count;
            this.age = age;
            this.capacity = capacity;
        }

        public override string ToString()
        {

            return "name:" + name + "price:" + price + "count:" + count + "age" + age;
        }
    }
}
