using System;

namespace ConsoleApp4
{
    class Program
    {
        static void chek(int a)
        {
            var d = a;
            if (d % 2 == 0)
            {
                Console.WriteLine("chetnoe");
            }
            else
            {
                Console.WriteLine("ne chetnoe");
            }
        }

        static void Main(string[] args)
        {
            chek(1);
            chek(2);
        }
    }
}