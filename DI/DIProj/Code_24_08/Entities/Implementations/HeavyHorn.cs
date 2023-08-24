using DIProj.Code_24_08.Entities.Contracts;

namespace DIProj.Code_24_08.Entities.Implementations;

public class HeavyHorn : IHorn
{
    public void HorningSound()
    {
        System.Console.WriteLine("Heavy Horn");
    }
}