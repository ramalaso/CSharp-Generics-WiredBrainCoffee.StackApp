using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(3.2);
            stack.Push(4.2);
            stack.Push(1.8);
            stack.Push(3.3);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
