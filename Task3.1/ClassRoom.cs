using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    internal class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(params Pupil[] pupils)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i < pupils.Length)
                    this.pupils.Add(pupils[i]);
                //else
                //    this.pupils.Add(new Pupil()); // Додавання звичайного учня, якщо аргументів менше 4.
            }
        }

        public void ShowPupilsActivities()
        {
            for (int i = 0; i < pupils.Count; i++)
            {
                Console.WriteLine($"Pupil {i + 1}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }
}
