using System;

namespace EulerP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 1;
            int numTwo = 2;
            int placeHolder = 0;
            int sum = 0;

            while (numOne < 4000000 && numTwo < 4000000)
            {
                if (numTwo % 2 == 0)
                {
                    sum += numTwo;
                }

                placeHolder = numTwo;
                numTwo = numOne + numTwo;
                numOne = placeHolder;
            }

            Console.WriteLine($"The sum of the even valued terms of the Fibonacci sequence whose values do not exceed four million is: {sum}");
        }
    }
}
