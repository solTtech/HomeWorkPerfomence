using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    internal class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good studies.");
        }

        public override void Read()
        {
            Console.WriteLine("Good reads.");
        }

        public override void Write()
        {
            Console.WriteLine("Good writes.");
        }

        public override void Relax()
        {
            Console.WriteLine("Good relaxes.");
        }
    }
}
