using System;
using System.Collections.Generic;

namespace lesson2.Solutions
{
    public class List
    {
        public void Problemm1()
        {
            List<int> list = new List<int>();

             int n, sum = 0;


             while (int.TryParse(Console.ReadLine(), out n))
                {
                   
                    sum += n;
                           
                    list.Add(n);
                }

                
                Console.WriteLine("Average: " + (list.Count > 0? sum / list.Count : 0));
        }
    }
}
