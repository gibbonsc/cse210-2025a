using System;

class Program
{
    static void Main(string[] args)
    {
        Costume sleuthCostume = new Costume();
        sleuthCostume.outfit = "trenchcoat and slacks";
        sleuthCostume.size = "extra large";
        sleuthCostume.footwear = "loafers";
        sleuthCostume.tools = "magnifying glass";

        Costume sidekickCostume = new Costume();
        sidekickCostume.outfit = "longsleeve flannel shirt and jeans";
        sidekickCostume.size = "large";
        sidekickCostume.footwear = "boots with spurs";
        sidekickCostume.tools = "work gloves and lasso rope";

        Costume victimCostume = new Costume();
        victimCostume.outfit = "tartan and kilt";
        victimCostume.size = "extra large";
        victimCostume.footwear = "ghillie brogues";
        victimCostume.tools = "bagpipes and sporran";

        Costume witnessCostume = new Costume();
        witnessCostume.outfit = "scrubs";
        witnessCostume.size = "medium";
        witnessCostume.footwear = "orthopedic shoes";
        witnessCostume.tools = "stethescope";

        Costume innocentSuspectCostume = new Costume();
        innocentSuspectCostume.outfit = "wetsuit";
        innocentSuspectCostume.size = "extra large";
        innocentSuspectCostume.footwear = "water shoes";
        innocentSuspectCostume.tools = "surfboard with ankle bracelet";

        Costume culpritCostume = new Costume();
        culpritCostume.outfit = "wetsuit";
        culpritCostume.size = "large";
        culpritCostume.footwear = "flippers";
        culpritCostume.tools = "snorkel and goggles";

        Console.WriteLine("Costumes needed for the mystery performance:");
        Console.WriteLine("\n\t The sleuth (detective):");
        sleuthCostume.Display();
        Console.WriteLine("\n\t The sidekick (cowboy):");
        sidekickCostume.Display();
        Console.WriteLine("\n\t The victim (bagpiper):");
        victimCostume.Display();
        Console.WriteLine("\n\t The witness (nurse):");
        witnessCostume.Display();
        Console.WriteLine("\n\t The innocent suspect (surfer):");
        innocentSuspectCostume.Display();
        Console.WriteLine("\n\t The actual culprit (snorkler):");
        culpritCostume.Display();
    }
}
