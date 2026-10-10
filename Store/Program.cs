using System.ComponentModel.Design.Serialization;

int Money = 100;
string buy = "";
int Cost = 0;
int price = 0;


while (Money > 0)
{
    {
    Console.WriteLine();
    Console.WriteLine($"you have {Money} gold coins!");
    Console.WriteLine("What do you want to buy?");
    Console.WriteLine("1: Sword 25 coins");
    Console.WriteLine("2: Bow 20 coins");
    Console.WriteLine("3: Sheild 15 coins");
    Console.WriteLine("4: this store sucks im leaving!");
    buy = Console.ReadLine();
    }

    if (buy == "4")
    {
        Console.WriteLine();
        Console.WriteLine("You leave the store.");
        break;
    }

    if (buy == "1") price += 25;
    else if (buy == "2") price += 20;
    else price += 15;

    Console.WriteLine();
    Console.WriteLine("how many do you want to purchase?");
    string antal = Console.ReadLine();
    int amount = 0;
    int.TryParse(antal, out amount);

    Cost = price *= amount;
    Money -= price;

    if (Cost > 100)
    {
    Console.WriteLine("You dont have enough coins for that!");
    Console.WriteLine();
    Money = Money + Cost;
    }
}

if (Money == 0) Console.WriteLine("You are out of money and leave the store");

Console.ReadLine();