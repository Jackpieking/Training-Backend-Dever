using DIProj.Code_24_08.Entities.Contracts;

namespace DIProj.Code_24_08.Entities.Implementations;

public class Car
{
    private readonly IHorn _horn;

    public Car(IHorn horn)
    {
        _horn = horn;
    }

    public void Beep()
    {
        _horn.HorningSound();
    }
}