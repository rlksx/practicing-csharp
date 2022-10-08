namespace fibonacci_debug;
class Program
{
    public static void Main(string[] args)
    {
        var fibonacciNumbers = new List<int> { 1, 1 };

        while (fibonacciNumbers.Count < 10)
        {
            var previus01 = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previus02 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(previus01 + previus02);
        }

        foreach (var item in fibonacciNumbers)
            Console.WriteLine(item);
    }
}