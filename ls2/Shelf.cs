using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls2
{
    internal class Shelf<T> where T : Item
    {
        internal object shelf;

        public int numberShelf { get; set; }
        public int column { get; set; }
        public double mishkal { get; set; }
        

        public Shelf(int numberShelf, int couls, double mishkal)
        {
            this.numberShelf = numberShelf;
            this.column = couls;
            this.mishkal = mishkal;
           
        }


    }
}