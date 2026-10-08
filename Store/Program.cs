int Money = 100;
string buy = "";
int price = 0;

Console.WriteLine($"you have {Money} gold coins!");
Console.WriteLine("What do you want to buy?");
Console.WriteLine("1: Sword 25 coins");
Console.WriteLine("2: Bow 20 coins");
Console.WriteLine("3: Sheild 15 coins");

if (buy == "1")
{
    price += 25;
}


else if(buy == "2") price += 20; 
else price += 15;