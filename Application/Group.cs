using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    class Group
    {
        public string No;
        public Student[] Students = new Student[0];
        public int StudentLimit;

        public Student[] AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            return Students;
        }
        public void GetInfo()
        {
            foreach (var item in this.Students)
            {
                Console.WriteLine($"Fullname:{item.FullName} GroupNo:{item.GroupNo} AvgPoint:{item.AvgPoint}");
            }
        }
        public void GetFiltered()
        {
            Console.WriteLine("Telebenin adi:");
            string name = Console.ReadLine();
            int count = 0;
            foreach (var item in Students)
            {
                if (item.FullName == name)
                {
                    count++;
                    Console.WriteLine($"Fullname:{item.FullName} GroupNo:{item.GroupNo} AvgPoint:{item.AvgPoint}");
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Axtardiginiz telebe yoxdu!");
            }
        }
    }
}
