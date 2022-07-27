using System;
using System.Collections.Generic;

namespace HWcsharp
{
    internal class Program
    {
        enum Operator { Add='+', Subtract='-', Multiply='*', Divide='/'};

        static int Addition(params int[]numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum+=numbers[i];
            }
           return sum;
        }

        static int Subtraction(params int[] numbers)
        {
            int sub = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sub -= numbers[i];
            }
            return sub;
        }

        static int Multiplication(params int[] numbers)
        {
            int mul =1;
            for (int i = 0; i < numbers.Length; i++)
            {
                mul *= numbers[i];
            }
            return mul;
        }
        static int Division(params int[] numbers)
        {
            int div = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] !=0)
                    div /= numbers[i];
            }
            return div;
        }
        static void Main()
        {
            int count;
           
            char operatorY;
           while(true)
            {
                List<int> arr = new List<int>();
                Console.WriteLine("How many operand you will add?");
                count= Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter operand "+(i+1));
                    arr.Add(Convert.ToInt32(Console.ReadLine()));
                }
                int[]array=arr.ToArray();
                Console.WriteLine("Enter operator ");
                operatorY=Convert.ToChar(Console.ReadLine());
                int result = operatorY switch
                {
                    '+' => Addition(array),
                    '-' => Subtraction(array),
                    '*' => Multiplication(array),
                    '/' => Division(array),
                    _ => 0
                };
                
                Console.WriteLine("Result: "+result);
           
            }
        }

        
    }
}
