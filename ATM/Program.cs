using System;
using DBT;
class Program
{
    static void Main(string[] args)
    {
        DebitCard dbtcard = new DebitCard();

        Console.Write("Insert your pin here:");
        dbtcard.Pin = Console.ReadLine();
    }
}
