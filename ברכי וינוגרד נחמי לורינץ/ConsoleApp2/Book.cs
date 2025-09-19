using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Book:Item 
    {
        public bool IsForChildren { get; set; }
        public bool IsExspensive { get; set; }

        public override string ToString()
        {
            return $"📘 Book: {Name}, Price: {Price}, For Children: {IsForChildren}";
        }
    }
}
