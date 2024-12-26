using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad studies.");
        }

        public override void Read()
        {
            Console.WriteLine("Bad reads.");
        }

        public override void Write()
        {
            Console.WriteLine("Bad writes.");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad relaxes.");
        }
    }
}
