using System.Threading.Tasks;
using System;

public class Kitchen
{
    
    public static async Task<string>  MakeTeaAsync()
    {
        
        var boilingwater = BoilWaterAsync();
       
        Console.WriteLine("Take the cups out");
        Console.WriteLine("put tea in cups");
        var water = await boilingwater;
        Console.WriteLine($"pour {water} in cups");
        var tea ="Tea is ready";
        return tea;

        // tea is ready

    }
    public static async Task<string> BoilWaterAsync()
    {
        Console.WriteLine("start the kettle");
        Console.WriteLine( "waiting for the Kettle to finish");
        await Task.Delay(6000);
        Console.WriteLine( "Kettle finised boling");
        

        return "Hot Water";
    }

}
