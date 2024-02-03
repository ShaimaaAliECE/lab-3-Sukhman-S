using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(String description, int score) : base(description, score) { }
        public override void Display() 
        { 
            Console.WriteLine($"Diamond{Description} is displayed");
        }

    }
}
