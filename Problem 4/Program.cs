using Problem_4;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> myList = new List<Person>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string info = Console.ReadLine();
            string[] infoArray = info.Split();
            if (int.Parse(infoArray[1]) > 30)
            {
                Person myPerson = new Person(infoArray[0], int.Parse(infoArray[1]));
                myList.Add(myPerson);
            }
        }
        Console.WriteLine();
        myList = myList.OrderBy(o => o.name).ToList();
        foreach (Person myPerson in myList)
        {          
            Console.WriteLine("{0} - {1}", myPerson.name, myPerson.age); 
        }
    }
}