using System.ComponentModel;
using System.Reflection.Metadata;
using ежедневник;
var DateList = new List<string>() { "26.11.2026", "07.10.2023" };
var Z = new List<string>()
    {
        "  проснуться.\n",
        "  Моё рождение.\n",
    };
var ZametkaDiscriptionList = new List<List<string>>();
ZametkaDiscriptionList.Add(new List<string>() { "купить кашу" });
ZametkaDiscriptionList.Add(new List<string>() { "выспаться." });
int position = 1;
int data = 1;
bool zhach = true;
Console.WriteLine("data");
while (true)
{
    ConsoleKeyInfo k = Console.ReadKey();
    if (k.Key == ConsoleKey.UpArrow)
    {
        if (position > 1)
        {
            position--;
        }
    }
    else if (k.Key == ConsoleKey.DownArrow)
    {
        if (position < 1)
        {
            position++;
        }
    }
    if (position > 3)
    {
        position--;
        Console.SetCursorPosition(0, position);
    }
    else if (k.Key == ConsoleKey.RightArrow)
    {
        if ((data + 1) < DateList.Count())
        {
            data = data + 1;
        }
    }
    else if (k.Key == ConsoleKey.LeftArrow)
    {
        if (data > 0)
        {
            data--;
        }
    }
    else if (k.Key == ConsoleKey.Z)
    {
        Console.Clear();
        Console.WriteLine("Заметка:");
        Z[data] = Z[data] + "  " + Console.ReadLine() + "\n";
        ZametkaDiscriptionList[data].Add("");
    }
    else if (k.Key == ConsoleKey.D)
    {
        NewData();
    }
    else if (k.Key == ConsoleKey.Escape)
    {
        zhach = false;
    }
    Console.Clear();
    Console.WriteLine(DateList[data]);
    Console.WriteLine(Z[data]);
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("[ D ] - новая дата.");
    Console.WriteLine("[ Z ] - новая заметка.");
}
while (zhach == true) ;
{
    Console.Clear();
    Console.WriteLine("Коннец.");
}
void NewData()
{
    Console.Clear();
    Console.WriteLine("Введите дату:");
    DateList.Add(Console.ReadLine());
    Z.Add("  ");
    ZametkaDiscriptionList.Add(new List<string>() { });
}


