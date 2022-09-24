using Problem_1;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);
    }
}