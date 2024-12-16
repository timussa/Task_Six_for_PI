namespace SomeoneProject
{
    internal class Program
    {
        public static int DoubleNum(int x)
        {
            return x * 2;
        }

        static void Main(string[] args)
        {
            throw new Exception("lalala");
            string num = "5";
            Console.WriteLine($"{num} * 2 = {DoubleNum(num)}")
        }

    }
}
