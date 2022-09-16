namespace IPv4Calculator;

public class CalculateMethods
{
    public static int CalculateMaximumHost(string? subnetzmaske)
    {
        var subnetArray = subnetzmaske.Split('.');
        var subnetMaskBits = 0;
        for (var i = 0; i < subnetArray.Length; i++)
            subnetMaskBits += Convert.ToString(Convert.ToInt32(subnetArray[i]), 2).Count(x => x == '1');

        var maximumHosts = (int) Math.Pow(2, 32 - subnetMaskBits) - 2;

        return maximumHosts;
    }

    public static string CaculateLastHost(string? ipAdress, string? subnetzmaske)
    {
        var broadcast = CalculateBroadCast(ipAdress, subnetzmaske);
        var splitBroadCast = broadcast.Split(".");
        var lastHostArray = splitBroadCast.Select(i => i.ToString()).ToArray();
        lastHostArray[3] = (int.Parse(lastHostArray[3]) - 1).ToString();

        var broadcastToString = lastHostArray.Select(i => i.ToString()).ToArray();

        var x = string.Join(".", broadcastToString);

        return x;
    }

    public static string CalculateFirstHost(string? ipAdress, string? subnetzmaske)
    {
        var netzId = CalculateNetzId(ipAdress, subnetzmaske);
        var netzIdArray = netzId.Select(i => i.ToString()).ToArray();
        netzIdArray[3] = (int.Parse(netzIdArray[3]) + 1).ToString();

        var firstHostArray = netzIdArray.Select(i => i.ToString()).ToArray();


        var firstHostIp = string.Join(".", firstHostArray);

        return firstHostIp;
    }

    public static string CalculateBroadCast(string? ipAdress, string? subnetzmaske)
    {
        var strCurrentIP = ipAdress.Split('.');
        var strIPNetMask = subnetzmaske.Split('.');

        var broadcast = new int[4];

        for (var i = 0; i < 4; i++)
        {
            broadcast[i] = int.Parse(strCurrentIP[i]) | (int.Parse(strIPNetMask[i]) ^ 255);
        }

        var broadcastToString = broadcast.Select(i => i.ToString()).ToArray();

        var x = string.Join(".", broadcastToString);

        return x;
    }

    public static string[] CalculateNetzId(string? ipAdress, string? subnetzmaske)
    {
        var ipAdressSplit = ipAdress?.Split('.');
        var subnetzmaskeSplit = subnetzmaske?.Split('.');
        var netzId = new int[4];

        for (var i = 0; i < 4; i++)
            netzId[i] = Convert.ToInt32(ipAdressSplit?[i]) & Convert.ToInt32(subnetzmaskeSplit?[i]);

        var netzIdToString = netzId.Select(i => i.ToString()).ToArray();

        return netzIdToString;
    }
}