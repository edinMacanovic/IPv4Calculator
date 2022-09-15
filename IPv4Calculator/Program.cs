using System.Threading.Channels;

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

        Console.WriteLine();
        Console.WriteLine("Das sind Ihre Ergebnisse: ");
        Console.WriteLine();

        Console.Write("Netz-ID: ");
        var calculatednetzId = CalculateNetzId(ipAdress, subnetzmaske);
        Console.WriteLine(string.Join(". ", calculatednetzId));

        Console.WriteLine();

        Console.Write("Broadcastadresse: ");
        var broadcast = CalculateBroadCast(ipAdress, subnetzmaske);
        Console.WriteLine(broadcast);

        Console.WriteLine();

        Console.Write("1. Host: ");
        var calculatedFirstHost = CalculateFirstHost(ipAdress, subnetzmaske);
        Console.WriteLine(calculatedFirstHost);

        Console.WriteLine();

        Console.Write("Letzter Host: ");
        var calculatedLastHost = CaculateLastHost(ipAdress, subnetzmaske);
        Console.WriteLine(calculatedLastHost);

        Console.WriteLine();

        Console.Write("Hosts/Netz: ");
        var calculatedMaximumHost = CalculateMaximumHost(subnetzmaske);
        Console.WriteLine(calculatedMaximumHost);




    }
}