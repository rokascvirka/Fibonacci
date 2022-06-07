using System;


namespace Fibonacci
{

    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new FibonacciGen();


            Console.WriteLine(fibonacci.EvenSum().ToString() + "     " + fibonacci.F3().ToString());
        }
    }
}