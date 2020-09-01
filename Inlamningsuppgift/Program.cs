using System;

namespace Inlamningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            //Console.Write("Hello:");
            //Console.WriteLine("Alireza Mohammadi");
            //Console.Write("76+34:");
            //Console.WriteLine(76 + 34);
            Console.Write("skriv en operator : +,-,x eller/ :");
            string d = Console.ReadLine();
            Console.Write("skriv ett nummer:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("skriv ett annat nummer:");
            int b = int.Parse(Console.ReadLine());
            if(d == "+")
            {
                c = a + b;
                
            }
             else if (d == "-")
            {
                c = a - b;
            }
             else if (d == "x")
            {
                c = a * b;
            }
            else 
            {
                c = a / b;

            }

            Console.WriteLine(c);
            Console.ReadLine();


        }
    }
}
