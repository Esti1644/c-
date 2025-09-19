using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public string Category { get; set; }

        public abstract override string ToString();
    }
}
