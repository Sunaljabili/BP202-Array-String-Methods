using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string no = "";
            
            do
            {
                Console.WriteLine("Qrupun nomresini daxil edin(ilk 2 herf boyuk daha sonra 3 reqem olmalidir): ");
                no = Console.ReadLine();
            } while (!(no.Length==5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4])));

            int studentLimit = 0;

            do
            {
                Console.WriteLine("Telebelerin max sayini daxil edin(0-20): ");
                studentLimit = Convert.ToInt32(Console.ReadLine());
            } while (studentLimit<0 || studentLimit>20);

            Group group = new Group
            {
                No = no,
                StudentLimit = studentLimit
            };
            bool check = true;
            while(check)
            {
                Console.WriteLine("1-Telebe elave et\n2-butun telebelere bax\n3-Telebeler uzre axtasir et\n0-Proqrami bitir");
                string answer = Console.ReadLine();
                if (answer == "1")
                {

                    if (group.StudentLimit >= group.Students.Length + 1 )
                    {
                        Console.WriteLine("Telebenin fullname-i daxil edin:");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Telebenin ortalama balini daxil edin:");
                        int avgpoint = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student(fullname)
                        {
                            GroupNo = no,
                            AvgPoint = avgpoint
                        };
                        group.AddStudent(student);
                    }
                    else
                        Console.WriteLine("Qrupun limiti dolub!");
                }
                else if(answer=="2")
                {
                    group.GetInfo();
                }
                else if(answer=="3")
                {
                    group.GetFiltered();
                }
                else if(answer =="0")
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("yalniz 1,2,3 ve ya 0 deyerini sece bilersiniz!");
                }
                   

            
                
            }


        }
    }
}
