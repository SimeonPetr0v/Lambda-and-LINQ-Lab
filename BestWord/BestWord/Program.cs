namespace BestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            var fWords = words
                .Where(w => w.Contains("est"))
                .Select(w => w.ToUpper())
                .ToArray();

            string fWordB = fWords.FirstOrDefault(w => w.Contains("B"));
            string lWordB = fWords.LastOrDefault(w => w.Contains("B"));

            if (!string.IsNullOrEmpty(fWordB))
                Console.WriteLine($"First best word: {fWordB}");

            if (!string.IsNullOrEmpty(lWordB))
                Console.WriteLine($"Last best word: {lWordB}");
        }
    }
    }
