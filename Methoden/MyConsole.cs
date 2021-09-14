using System;

class MyConsole {

    public static void SchreibeZeile(string str) 
    {
        Console.WriteLine("!!!" + str + "!!!");
    }

    public static double ReadNumber() 
    {
        string eingabe = Console.ReadLine().Trim();
        double number = Convert.ToDouble(eingabe);
        return number;
    }
}