using Problem_6;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> myList = new List<Employee>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string info = Console.ReadLine();
            string[] infoArray = info.Split();
            Employee employee;
            if (infoArray.Length == 4)
                employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3]);
            else if (infoArray.Length == 6)
                employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3], infoArray[4], int.Parse(infoArray[5]));
            else if (infoArray[4].Contains("@"))
                employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3], infoArray[4]);
            else employee = new Employee(infoArray[0], double.Parse(infoArray[1]), infoArray[2], infoArray[3], int.Parse(infoArray[4]));
            myList.Add(employee);
        }
        var best = myList.GroupBy(g => g.department)
            .Select(g => new
            {
                Average = g.Average(e => e.salary),
                Department = g.Key
            }).OrderByDescending(d => d.Average).First();
        Console.WriteLine();
        Console.WriteLine("Highest Average Salary:" + best.Department);
        myList = myList.FindAll(g => g.department == best.Department).OrderByDescending(g => g.salary).ToList();
        foreach (Employee employee in myList)
        {
            if (employee.department == best.Department)
                Console.WriteLine(employee);
        }
    }
}