
using System.Threading.Tasks;
using Training_Backend_Dever._18_09_2023_Db_Connection_And_ORM_Introduce;

class Program
{
    private static async Task Main()
    {
        await _18_09_2023_Db_Connection_And_ORM_IntroduceRunExtensionMethod.ExecuteAsync();
    }
}

public interface IPerson
{
    void DoSomething();
}

public class Person : IPerson
{
    public void DoSomething()
    {
        System.Console.WriteLine("From person");
    }
}

public class Student : Person, IPerson
{
    public new void DoSomething()
    {
        base.DoSomething();
        System.Console.WriteLine("From student");
    }
}