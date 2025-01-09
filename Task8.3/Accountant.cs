using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._3
{
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            int requiredHours = (int)worker;
            return hours > requiredHours;
        }
    }
}
