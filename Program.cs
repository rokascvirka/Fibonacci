using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciList = new List<int>(new int[] { 1, 2 });
            var evenList = new List<int>();
            

            for (int i = 1; i < 100; i++)
            {
                var firstNumber = fibonacciList[i - 1];
                var secondNumber = fibonacciList[i];
                var newValue = firstNumber + secondNumber;

                if ((newValue < 4000000))
                {
                    fibonacciList.Add(newValue);
                }
                else
                {
                    break;
                }

            }

            foreach (var even in fibonacciList)
            {
                if (even % 2 == 0)
                {
                    evenList.Add(even);
                }
            }

            Console.WriteLine(evenList.Sum());
        }
    }
}
