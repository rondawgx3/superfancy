// See https://aka.ms/new-console-template for more information
using System;

namespace fun{
    class Program
    {
        public static string fib(int i)
        {
            Console.WriteLine("Here is the first "+i+" numbers of the fibonacci sequence:");
            int a = 0;
            int b = 1;
            int c = 0;
            int j = 1;
            while(j <= i){
                c = b;
                b = b+a;
                Console.WriteLine(j + ")\t" + b);
                a = c;
                j=j+1;
            }
            return "\n";
            // if (i <= 2) return 1;
            // return fib(i - 2) + fib(i-1);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("The current time is: "+DateTime.Now);
            Console.WriteLine(fib(20));
        }
    }
}