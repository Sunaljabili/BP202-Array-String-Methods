using System;
using System.Collections.Generic;
using System.Text;

namespace Classworks
{
    class Student
    {
        public string Name;
        public string Surname;
        public string GroupNo;
        public int Point;
        public bool isGraduated = true;

        public Student(int point)
        {
            Point = point;
        }

        public void FullnameMethod()
        {
            Console.WriteLine($"Adi : {Name}  Soyadi : {Surname}");
        }
        public void EveryData()
        {
            Console.WriteLine($"Adi : {Name}  Soyadi : {Surname} Qrup:{GroupNo} Qiymeti :{Point}");
            if (isGraduated)
            {
                Console.WriteLine("Telebe Mezun Olub");
            }
            else
            {
                Console.WriteLine("Mezun olmayib");
            }

        }
        public void NextExam()
        {
            if (Point > 80)
            {
                Console.WriteLine("Novbeti imtahana daxil ola bilersiniz.");
            }
            else
            {
                Console.WriteLine("Kesr :/");
            }
        }

    }
}
