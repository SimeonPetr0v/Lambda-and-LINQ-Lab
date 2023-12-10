namespace Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');

            foreach (var numb in nums)
            {
                int num = int.Parse(numb);
                Console.WriteLine($"{num} is odd - {IsOdd(num)}");
            }
        }
        static bool IsOdd(int x) => x % 2 != 0;
    }
}