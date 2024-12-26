using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    internal class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent studies.");
        }

        public override void Read()
        {
            Console.WriteLine("Excelent reads.");
        }

        public override void Write()
        {
            Console.WriteLine("Excelent writes.");
        }

        public override void Relax()
        {
            Console.WriteLine("Excelent relaxes.");
        }
    }
}
