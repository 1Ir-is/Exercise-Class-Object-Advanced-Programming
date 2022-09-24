// See https://aka.ms/new-console-template for more information
using Problem_3;
using System.Reflection;

MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
if (oldestMemberMethod == null || addMemberMethod == null)
{
    throw new Exception();
}
Family myFamily = new Family();
int N = int.Parse(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    string info = Console.ReadLine();
    string[] infoArray = info.Split();
    Person myPerson = new Person(infoArray[0], int.Parse(infoArray[1]));
    myFamily.AddMember(myPerson);
}
Person oldestPerson = myFamily.GetOldestMember();
Console.WriteLine();
Console.WriteLine("{0} {1}", oldestPerson.name, oldestPerson.age);
