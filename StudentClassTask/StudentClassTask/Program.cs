using Core.Models;

namespace StudentClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Elvin Sarkarov");
            student1.GroupNo = 11;
            student1.AvgPoint = 87;

            Student student2 = new Student("Elman Vezirli");
            student1.GroupNo = 10;
            student1.AvgPoint = 65;

            Student student3 = new Student("Nezrin Nezerliyeva");
            student1.GroupNo = 10;
            student1.AvgPoint = 98;

            Student student4 = new Student("Samir Agayev");
            student1.GroupNo = 11;
            student1.AvgPoint = 65;

            Group group = new Group("AS123", 5);

            group.ShowGroupDetail();
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
        }
    }
}