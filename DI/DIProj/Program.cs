using System;
using System.Threading.Tasks;
using DIProj.Code_24_08.Entities.Contracts;
using DIProj.Code_24_08.Entities.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DIProj;

public class Program
{
    /**
     *
     * scope : dùng xong là xóa đi
     * transient: tạo mới liên tục, không biết khi nào là xóa
     */

    public static async Task Main(string[] args)
    {
        ServiceCollection collection = new();

        collection.AddScoped<IHorn, HeavyHorn>();
        collection.AddSingleton<Car>();

        await using (var provider = collection.BuildServiceProvider())
        {
            var car = provider.GetRequiredService<Car>();   

            car.Beep();
        }
    }
}