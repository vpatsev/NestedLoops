
string destination = Console.ReadLine();

while (destination != "End")
{
    double neededSum = double.Parse(Console.ReadLine());
    double savedMoney = 0;

    while (neededSum > savedMoney)
    {
        double currentMoney = double.Parse(Console.ReadLine());

        savedMoney += currentMoney;

        Console.WriteLine($"Collected: {savedMoney:F2}");




    }
    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();

}


