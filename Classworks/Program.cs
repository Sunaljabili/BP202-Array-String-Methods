using System;

namespace Classworks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            // 1. Ededlerden ibaret array qebul eden method yazin.
            // methoduna uygun CustomSort(int[] arr) methodunu
            //yazin.
            //int[] arr = { 52, 52, 34, 54 };
            //foreach (var item in CustomSort(arr))
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region Task-2

            Student student = new Student(87);
            student.Name = "Ayten";
            student.Surname = "Zeynalova";
            student.GroupNo = "BP202.S";
            student.FullnameMethod();
            student.EveryData();
            student.NextExam();
            #endregion
        }

        #region Task-1
        //static int[] CustomSort(int[] arr)
        //{
        //    int temp = 0;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (arr[i] < arr[j])
        //            {
        //                temp = arr[i];
        //                arr[i] = arr[j];
        //                arr[j] = temp;
        //            }
        //        }
        //    }
        //    return arr;
        //}
        #endregion





    }
}
