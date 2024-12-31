using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    public abstract class AbstractHandler
    {
        public void Open() 
        {
            Console.WriteLine("Open");
        }
        public void Create() 
        { 
            Console.WriteLine("Create"); 
        }
        public void Change() 
        { 
            Console.WriteLine("Change"); 
        }
        public void Save() 
        { 
            Console.WriteLine("Save"); 
        }
    }
}
