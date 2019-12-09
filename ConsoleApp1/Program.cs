using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are the 2 arrays
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };
            List<int> list_1 = new List<int>(list1);
            List<int> list_2 = new List<int>(list2);


            //Start Answer for (a)
            List<int> list3 = new List<int>();
            foreach (var i in list1)
            {
                if (list_2.BinarySearch(i) >= 0)
                {
                    list3.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", list3));
            //End Answer for (a) 


            //Start Answer for (b) 
            List<int> list4 = new List<int>();
            foreach (var i in list1)
            {
                if (list_2.BinarySearch(i) < 0)
                {
                    list4.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", list4));
            //End Answer for (b)


            //Start Answer for (c)
            List<int> list5 = new List<int>();
            foreach (var i in list2)
            {
                if (list_1.BinarySearch(i) < 0)
                {
                    list5.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", list5));
            //End Answer for (c) 


            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}