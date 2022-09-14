namespace IPv4Calculator;
// Note: actual namespace depends on the project name.

internal class Program : CalculateMethods
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie ihre IP-Adresse ein :");
        var ipAdress = Console.ReadLine();

        Console.WriteLine("Bitte geben Sie ihre Subnetzmaske ein :");

        var subnetzmaske = Console.ReadLine();

        var calculatednetzId = CalculateNetzId(ipAdress, subnetzmaske);
        Console.WriteLine(string.Join(". ", calculatednetzId));

        var broadcast = CalculateBroadCast(ipAdress, subnetzmaske);
        Console.WriteLine(broadcast);

        var calculatedFirstHost = CalculateFirstHost(ipAdress, subnetzmaske);
        Console.WriteLine(calculatedFirstHost);

        var calculatedLastHost = CaculateLastHost(ipAdress, subnetzmaske);
        Console.WriteLine(calculatedLastHost);

        CalculateMaximumHost(subnetzmaske);
    }
}