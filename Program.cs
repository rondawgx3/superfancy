using System;

namespace fun{
    class Program
    {
        public static string fib(int i)
        {
            
            Console.WriteLine("Here are the first "+i+" numbers of the fibonacci sequence:");
            Int64 a = 0;
            Int64 b = 1;
            Int64 c = 0;
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
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F, World!");
            Console.WriteLine("The current time is: "+DateTime.Now);
            Console.Write("(do not enter numbers greater than 90 as integer overflow will occur)\nHow many numbers of the fibonacci sequence: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(fib(amount));
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }
    }
}
