namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (IsValidName(name))
            {
                Console.WriteLine($"Hello, {name}!");

                foreach (var value in name.Select(c => c + 10))
                {
                    Console.WriteLine(value);
                }
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }

        static bool IsValidName(string name) => name.Length >= 3 && char.IsUpper(name[0]) && !name.Any(char.IsDigit);
    }
}
    