using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public String Description;
        public CollectionBoard Board;
        public Collectable(string description)
        {
            Description = description;

        }

        public virtual void Display() 
        { 
        }
        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
    }
}
