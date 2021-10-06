
using System;
using System.Linq;

namespace lesson1.Solutions
{
    public class Lab2
    {
        public void Problem1()
        {
           Console.WriteLine(222222);
           Console.WriteLine(2+"    "+2);
           Console.WriteLine(2+"    "+2);
           Console.WriteLine(222222);
        }
        public void Problem2()
        {
           Console.WriteLine(" A");
           Console.WriteLine(" AA");
           Console.WriteLine("A A");
           Console.WriteLine("AAAA");
        }
        public void Problem3()
        {
           Console.WriteLine("Brithdate");

            Console.Write("Enter Month: ");
            string son = Console.ReadLine();

            int a = int.Parse(son);
            // string e = String.Format("{0:D2},a");
            Console.Write("Enter Date: ");
            string b = Console.ReadLine();

            int d = int.Parse(son);
           string e = a.ToString().PadLeft(2,'0');
           string k = b.ToString().PadLeft(2,'0');

            Console.WriteLine("Brithdate is" + " "  +  e  + '-' +  k);
        }
        public void Problem5()
        {
           string son = System.Console.ReadLine();
           int a = int.Parse(son);
           Console.WriteLine(a+""+a+""+a+""+a+""+a+""+a);
           Console.WriteLine(a+"    "+a);
           Console.WriteLine(a+"    "+a);
           Console.WriteLine(a+""+a+""+a+""+a+""+a+""+a);
        }
        public void Problem7()
        {
           string son = System.Console.ReadLine();
           int a = int.Parse(son);
           for (int i=1; i<=9; i++)
           {
               Console.WriteLine(a+"*"+i+"="+a*i);
           }
        }
        public void Problem8()
        {
            int i,fact=1,number;      
            Console.Write("Enter any Number: ");      
            number= int.Parse(Console.ReadLine());     
            for(i=1;i<=number;i++)
            {      
                fact=fact*i;      
            }      
            Console.WriteLine("Factorial of " +number+" is: "+fact);
        }
        public void Problem3_2()
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area->"+width*length);
        }
        public void Problem3_3()
        {
                    float val2;
        if (!float.TryParse(Console.ReadLine(), out val2))
        {
            Console.WriteLine("Not a valid float");
        }
        else {
            Console.WriteLine(Math.Round(val2));
        }
        }
        public void Problem3_4()
        {
            char ch;
            Char.TryParse(Console.ReadLine(), out ch);
            if (ch>=65 && ch<=90)
            {
                Console.WriteLine(char.ToLower(ch));
            }  
            else if (ch>=97 && ch<=122)
            {
                Console.WriteLine(char.ToUpper(ch));
            }        
        }
        public void Problem3_2_2()
        {
            String a = Console.ReadLine();
            String b = Console.ReadLine();
            float c=float.Parse(a);
            float d = float.Parse(b);
            Console.WriteLine("Area->"+c*d);
        }
        public void Problem3_1()
        {
            string a = Console.ReadLine();
            int b=int.Parse(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(Convert.ToChar(b));
        }
    }
}