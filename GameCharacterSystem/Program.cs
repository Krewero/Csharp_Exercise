using System;

public class Program
{
    static void Main(string[] args)
    {
        Game theGame = new Game();

        Warrior warrior = new Warrior("Solaire", 200, 20, 10);
        Mage mage = new Mage("King", 170, 25, 10);
        Dragon dragon = new Dragon("Spyro", 150, 30, 10);

        Console.WriteLine($"{warrior.Name} is a warrior");
        Console.WriteLine($"{mage.Name} is a mage");
        Console.WriteLine($"{dragon.Name} is a dragon");

        theGame.Battle(warrior, dragon);
    }
}
