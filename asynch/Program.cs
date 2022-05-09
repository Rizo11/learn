namespace asynch;

class Programm
{
    static async Task Main(string[] args)
    {
        System.Console.WriteLine(await MakeTeaAsync());
    }

    // public static string MakeTea()
    // {
    //     var water = BoilWater();

    //     System.Console.WriteLine("take the cups out");
    //     System.Console.WriteLine("put the tea in the cup");
    //     var tea = $"pour {water} in the cup";

    //     return tea;

    // }

    // public static string BoilWater()
    // {
    //     System.Console.WriteLine("start the kettle");
    //     System.Console.WriteLine("wait for the kettle to boil");
    //     Task.Delay(1000).GetAwaiter().GetResult();
    //     System.Console.WriteLine("water boiled");
    //     return "water";
    // }

    public static async Task<string> MakeTeaAsync()
    {
        var boilingWater = BoilWaterAsync();

        System.Console.WriteLine("take the cups out");
        System.Console.WriteLine("put the tea in the cup");

        var water = await boilingWater;
        var tea = $"pour {water} in the cup";

        return tea;

    }

    public static async Task<string> BoilWaterAsync()
    {
        System.Console.WriteLine("start the kettle");

        System.Console.WriteLine("wait for the kettle to boil");
        await Task.Delay(1000);

        System.Console.WriteLine("water boiled");
        return "water";
    }
}