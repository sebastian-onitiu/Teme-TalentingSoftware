using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Swap (ref string a , ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static int Sum(int a , int b , int c, int d=0)
        {
            return a + b + c + d;
        }

        static void Switchgrades(int notes)
        {
            switch(notes)

            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        Console.WriteLine("Very Bad");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Bad");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Acceptable");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Good");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Very Good");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Excellent");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nu ai introdus corect nota");
                        break;
                    }
                 
            }
        }

        static void Main(string[] args)
        {

              Console.WriteLine("introdu sirul x");
              string x = Console.ReadLine();
              Console.WriteLine("introdu sirul y");
              string y = Console.ReadLine();
              Swap(ref x, ref y);
              Console.WriteLine(x+' '+y);

            Console.WriteLine("Introdu cele 4 valori");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(a,b,c,d));
            Console.WriteLine(Sum(a, b, c));

            Console.WriteLine("introdu nota obtinuta");
            int nr = int.Parse(Console.ReadLine());
            Switchgrades(nr);
        }
    }
}
