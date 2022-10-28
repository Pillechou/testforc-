namespace ConsoleApp1;

public class Player
{
    
    private static Player _instance;
    private double money = 10.0;
    private string name = Environment.UserName;
    private Settings _settings = Settings.GetInstance();

   


    public static Player GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Player();
        }

        return _instance;
    }
    public void Work()
    {
        money += (10 * _settings.GetmoneyMultiplier());
    }
    public void Upgrade()
    {
        if (money < _settings.GetupgradeCost())
        {
            Console.WriteLine("You cant do this");

        }
        else
        {
            money -= _settings.GetupgradeCost();
            Console.WriteLine(_settings.GetmoneyMultiplier()+Environment.NewLine+_settings.GetmoneyMultiplierMultiplier());
            _settings.SetmoneyMultiplier(_settings.GetmoneyMultiplier()+_settings.GetmoneyMultiplierMultiplier());
            _settings.SetmoneyMultiplierMultiplier(_settings.GetmoneyMultiplier() *1.3);
            _settings.SetupgradeCost(_settings.GetupgradeCost() * 1.6);

        }
    }



    public string getName()
    {
        return name;
    }

    public double getMoney()
    {
        return money;
    }
    public void setMoney(double a)
    {
        money =a;
    }
    public void printInfo()
    {
        
        Console.WriteLine($"Upgrade cost : {_settings.GetupgradeCost()} {Environment.NewLine}Multiplier : {_settings.GetmoneyMultiplier()} {Environment.NewLine}Money: {money}");
    }
}