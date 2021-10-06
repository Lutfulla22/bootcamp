using System;
namespace lesson2.Solutions
{
    public class Lab5
    {
        public void Problem1()
        {
            int n = int.Parse(Console.ReadLine());
            if(n<0)
            {
                Console.WriteLine("Ichkarida o'yna");
            }
            if(0<=n && n<40)
            {
                System.Console.WriteLine("Tashqarida o'yna");
            }
            else
            {
                Console.WriteLine("Ichkarida o'yna");
            }
        }
        public void Problem2()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if(m==n*n)
            {
                System.Console.WriteLine(n+"*"+n+"="+m);
            }
            if(n==m*m)
            {
                System.Console.WriteLine(m+"*"+m+"="+n);
            }
            else
            {
                System.Console.WriteLine("none");
            }
        }
        public void Problem3()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if(n>m)
            {
                System.Console.WriteLine(n);
            }
            else
            {
                System.Console.WriteLine(m);
            }
        }
        public void Problem4()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int max=n;
            int min=n;
            if (m > max) 
                max = m;
            if (a > max)
                max = a;
            if (m < min)
                min = m;
            if (a < min)
                min = a;
                System.Console.WriteLine(max+" "+min);
        }
        public void Problem5()
        {
            int a = int.Parse(Console.ReadLine());
            if (a%2==0 && a%3==0 && a%5==0)
  
            System.Console.WriteLine("A");
            
            else if (a%2==0 && a%3==0)
            
            System.Console.WriteLine('B');
            
            else if (a%2==0 && a%5==0)
            
            System.Console.WriteLine('C');
            
            else if (a%3==0 && a%5==0)
            
             System.Console.WriteLine('D');
            
            else if (a%2==0 || a%3==0 || a%5==0)
            
            System.Console.WriteLine("E");
            
            else 
            
            System.Console.WriteLine('N');
        }
        public void Problem6()
        {
            int x = int.Parse(Console.ReadLine());
            if ((x%4==0 && x%100!=0 ) || (x%400==0))
            System.Console.WriteLine("Leap year");
            else
            System.Console.WriteLine("Normal year");
        }
        public void Problem7()
        {
            int a = int.Parse(Console.ReadLine());
            int v=5;
            if (a==v)
            {
  
                System.Console.WriteLine("Correct");
            
            }
            else 
            {
            
                if (a>v)
                {
            
                System.Console.WriteLine("Down");

                }
            
                else 
                {
            
                System.Console.WriteLine("Up");
            
                    int c = int.Parse(Console.ReadLine());
                    
                    if (c==v)
                    
                    System.Console.WriteLine("Correct");
                    
                    else 
                    {
                    
                        if (c>v)
                        {
                    
                        System.Console.WriteLine("Down");

                        }
                    
                        else 
                        {
                    
                        System.Console.WriteLine("Up");
            
                        }
                    }
                }
            }
        }
        public void Problem8()
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
            else 
            System.Console.WriteLine("None");
        }
        public void Problem9()
        {
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());
            int j1 = int.Parse(Console.ReadLine());
            int j2 = int.Parse(Console.ReadLine());
            int j3 = int.Parse(Console.ReadLine());
            int strike = 0;

                    int ball = 0;

                    if(t1 == j1)

                    {

                        strike++;

                    }

                    else if(t1 == j2 || t1 == j3)

                    {

                        ball++;

                    }

                    if(t2 == j2)

                    {

                        strike++;

                    }

                    else if(t2 == j3 || t2 == j1)

                    {

                        ball++;

                    }

                        if(t3 == j3)

                        {

                        strike++;
                        }

                        else if(t3 == j1 || t3 == j2)

                        {

                        ball++;
                        System.Console.WriteLine(strike+"S"+ball+"B");
                        }
                        else 
                        {
                            System.Console.WriteLine(strike+"S"+ball+"B");
                        }
                        
                        


         }

                       
                        
                        
                        
     }
}
    


