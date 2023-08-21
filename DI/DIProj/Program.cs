namespace DIProj;

public class Program
{
    /**
     * Lập trình bất đồng bộ trong c# là đa luồng hoặc đơn luồng (tùy compiler)
     *
     * không thể biết trước thread nào thực hiện
     *
     * void => Task
     * int, long, short => Task<datatype>
     * 
     * async => generate bunch of machine code
     */

    public static async Task Main(string[] args)
    {
        var task = HelloAsync();

        Console.WriteLine("Do something else");

        var res = await task;

        Console.WriteLine($"Result: {res}");
    }

    public static async Task<string> HelloAsync()
    {
        await Task.Delay(1000);

        return "Hello";
    }
}