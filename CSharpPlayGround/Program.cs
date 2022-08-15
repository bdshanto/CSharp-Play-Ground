namespace CSharpPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new SimpleStack<double>();
            stack.Add(1.1);
            stack.Add(2.2);
            stack.Add(3.8);

            double count = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}\n");
                count += item;
            }
            Console.WriteLine($"Sum: {count}");
            Console.ReadLine();
        }
    }
}