using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDouble();
            StackString();
        }

        private static void StackDouble()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item : {item}");
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackString()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Pluralsight");
            stack.Push("Target");
            stack.Push("Nike");

            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine($"Item : {item}");
            }
        }
    }
}
