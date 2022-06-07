using System.Collections.Generic;


namespace Fibonacci
{
    public class FibonacciGen
    {
        public int EvenSum()
        {
            var fibonacciList = new List<int>(new int[] { 1, 2 });

            var newValue = 0;
            var sum = 0;


            while (newValue < 4000000)
            {
                var firstNumber = fibonacciList[fibonacciList.Count - 2];
                var secondNumber = fibonacciList[fibonacciList.Count - 1];

                newValue = firstNumber + secondNumber;

                fibonacciList.Add(newValue);

                if (newValue % 2 == 0) sum += newValue;
            }

            return sum;
        }

        public int F3()
        {

            var f1 = 1;
            var f2 = 2;
            var f3 = 0;
            var sum = 0;

            while ((f3 < 4000000))
            {
                f3 = f1 + f2;
                if (f3 % 2 == 0) sum += f3;

                f1 = f2;
                f2 = f3;

            }

            return sum;
        }
    }
}
