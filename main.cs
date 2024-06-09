using System;

class Hurricane
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the wind speed (in miles per hour):");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        string category = GetHurricaneCategory(windSpeed);
        Console.WriteLine($"{category}");
    }

    static string GetHurricaneCategory(double windSpeed)
    {
        if (windSpeed >= 157)
        {
            return "Category five hurricane";
        }
        else if (windSpeed >= 130)
        {
            return "Category four hurricane";
        }
        else if (windSpeed >= 111)
        {
            return "Category three hurricane";
        }
        else if (windSpeed >= 96)
        {
            return "Category two hurricane";
        }
        else if (windSpeed >= 74)
        {
            return "Category one hurricane";
        }
        else
        {
            return "Not a hurricane";
        }
    }
}
