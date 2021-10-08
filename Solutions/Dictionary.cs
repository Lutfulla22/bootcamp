using System;

namespace lesson2.Solutions
{
    public class Dictionary
    {
        public void Prob1()
    {
        int Students = 0;
        int Grades = 0;

        Students = Convert.ToInt32(Console.ReadLine());

        Grades = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[Students, Grades];

        for (int r = 0; r < Students; r++)
            for (int c = 0; c < Grades; c++)
            {
            Console.Write("{0} {1} ", c + 1, r + 1);
                arr[r, c] = Convert.ToInt32(Console.ReadLine());
            }
        for (int r = 0; r < arr.GetLength(0); r++)
        {
            int studentSum = 0;
            int testCount = 0;
            for (int c = 0; c < arr.GetLength(1); c++)
            {
                studentSum += arr[r, c];
                testCount++;
            }
            string gradeLetter = "";
            double average = studentSum / testCount;
            Console.WriteLine("\n" + (r + 1).ToString() + average.ToString());

            if (average >= 90)
            {
                gradeLetter = "A";
            }
            else if (average >= 80 && average < 90)
            {
                gradeLetter = "B";
            }
            else if (average >= 70 && average < 80)
            {
                gradeLetter = "C";
            }
            else if (average >= 60 && average < 70)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            Console.WriteLine("Student " + (r + 1).ToString() + " will recieve a(n) " + gradeLetter + " in the class.\n");
        }

    }
    }
}