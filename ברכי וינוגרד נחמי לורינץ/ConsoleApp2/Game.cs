using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Game:Item
    {
        public string Type { get; set; }

        public override string ToString()
        {
            return $"🎲 Game: {Name}, Price: {Price}, Type: {Type}";
        }
    }
}
