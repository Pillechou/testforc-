// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using ConsoleApp1;


Player player = Player.GetInstance();


string menuStr = "You can : "+Environment.NewLine ;
List<string> choiceMenu = new List<string>() {"work","upgrade","money"};


Console.WriteLine($"Welcome {player.getName()} to MoneyX");
Console.WriteLine(menuStr);
foreach (var i in choiceMenu)
{
    Console.WriteLine(i + Environment.NewLine);
}
while (true)
{
    Game();
}



void Game()
{
    player.printInfo();
    ConsoleKeyInfo choice = Console.ReadKey(true);
    switch (choice.Key)
    {
        case ConsoleKey.W:
            player.Work();
            
            break;
        
        case ConsoleKey.U:
            player.Upgrade();
            break;
        
        case ConsoleKey.A:
            player.setMoney(9999999999);
            break;

        default:
            Console.WriteLine("You cant do this");
            break;
    }
    //Console.Clear();
}


