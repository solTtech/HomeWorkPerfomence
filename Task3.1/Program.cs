namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(),new BadPupil(),new GoodPupil());

            classRoom.ShowPupilsActivities();
        }
    }
}
