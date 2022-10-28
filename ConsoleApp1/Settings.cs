using System.ComponentModel;

namespace ConsoleApp1;

public class Settings
{
    private Settings(){}
    private static Settings _instance;
    private double moneyMultiplier = 1.0;
    private double upgradeCost = 10.0;
    private double moneyMultiplierMultiplier = 0.2;
    
    
    
    public static Settings GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Settings();
        }
        return _instance;
    }

    
    public double GetupgradeCost()
    {
        return upgradeCost;
    }

    public void SetupgradeCost(double a)
    {
        upgradeCost = a;
    }
    
    public double GetmoneyMultiplierMultiplier()
    {
        return moneyMultiplierMultiplier;
    }

    public void SetmoneyMultiplierMultiplier(double a)
    {
        moneyMultiplier = a;
    }
    
    
    public double GetmoneyMultiplier()
    {
        return moneyMultiplier;
    }
    public void SetmoneyMultiplier(double a)
    {
        moneyMultiplier = a;
    }

}