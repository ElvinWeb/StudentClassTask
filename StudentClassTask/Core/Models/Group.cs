using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Group
    {
        private int _stdLimit;
        private string _no;
        public string No
        {
            get { return _no; }
            set
            {
                if (value.Length == 5 && Char.IsUpper(value[0]) && Char.IsUpper(value[1]) && Char.IsDigit(value[2]) && Char.IsDigit(value[3]) && Char.IsDigit(value[4]))
                {
                    this._no = value;
                }
                else
                {
                    Console.WriteLine("Group adi mutleq iki boyuk herif ve qalan uçu reqem olmalidir!. Mes: QK111 , BB303 ....");
                }
            }
        }

        public Student[] students = Array.Empty<Student>();
        public int StudentLimit
        {
            get { return _stdLimit; }
            set
            {
                if (value > 0 && value < 20)
                {
                    this._stdLimit = value;
                }
                else
                {
                    Console.WriteLine("Telebe limiti 0 ve 20 araliginda olmalidi!");
                }
            }
        }

        public Group(string groupNo, int stdLimit)
        {
            this.No = groupNo;
            this.StudentLimit = stdLimit;
        }
        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[^1] = student;
            }
            else
            {
                Console.WriteLine("Limiti keçdi!");
            }

        }
       
        public void ShowAllStduents()
        {
            foreach (Student std in students)
            {
                Console.WriteLine($"FullName: {std.FullName}; No: {std.GroupNo}; Average: {std.AvgPoint};");
            }
        }
        public void ShowGroupDetail()
        {
            Console.WriteLine($"Group adi:{No} LIMIT:{StudentLimit}");
        }
    }
}
