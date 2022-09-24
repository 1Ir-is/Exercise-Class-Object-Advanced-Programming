using Problem_5;

internal class Program
{
    private static void Main(string[] args)
    {
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();
        int result = DateModifier.DifferenceDate(date1, date2);
        Console.WriteLine();
        Console.WriteLine(result);
    }
}