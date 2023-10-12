using Core.Models;

namespace StudentClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Elvin Sarkarov");
            student1.GroupNo = "AS123";
            student1.AvgPoint = 87;

            Student student2 = new Student("Elman Vezirli");
            student2.GroupNo = "AS123";
            student2.AvgPoint = 65;

            Student student3 = new Student("Nezrin Nezerliyeva");
            student3.GroupNo = "AK101";
            student3.AvgPoint = 98;

            Student student4 = new Student("Samir Agayev");
            student4.GroupNo = "AK101";
            student4.AvgPoint = 65;

            Group group = new Group("AS123", 5);

            //group.ShowGroupDetail();
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            group.ShowAllStduents();


        }
    }
}