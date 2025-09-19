using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Shelf
    {
        public int ShelfNumber { get; set; }
        public int ColumnNumber { get; set; }
        public double Capacity { get; set; } 
        public List<Item> Items { get; set; } = new List<Item>();

        public double TotalWeight => Items.Sum(item => item.Weight);

        public bool IsFull => TotalWeight >= Capacity;

        public override string ToString()
        {
            return $"Shelf {ShelfNumber}-{ColumnNumber} ({TotalWeight}/{Capacity} kg):\n" +
                   string.Join("\n", Items.Select(item => " - " + item.ToString()));
        }
    }
}
