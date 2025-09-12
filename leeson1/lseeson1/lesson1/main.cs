using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace lesson1
{
    public class Class1
    {
        static void Main(string[] args) {
            circale[] circales = new circale[4];
            Rectangle[] rectangles = new Rectangle[8];
            Rectangle[] rectangles1 = new Rectangle[8];
            foreach (circale item in circales) {
                if (item.scoup>7)
                    Console.WriteLine(item.scoup+" "+item.color);

    }
            var rectangle2=from item in rectangles
                           where item.length<5
                           select item;

        }
    }
}
