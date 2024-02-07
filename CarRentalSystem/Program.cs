using System;
using RentalSystem;

public class Program
{
    static void Main(string[] args)
    {
        Car[] cars =
        {
            new Car("Toyota", "Corolla", 50.00m),
            new Car("FIAT", "Panda", 35.00m),
            new Car("Citroen", "C4", 45.00m),
            new Car("Nissan", "Micra", 55.00m)
        };

        Console.WriteLine("Welcome to the rental car system!!\n");
        bool exit = false;
        while (exit == false)
        {
            Console.WriteLine("1.Rent a car\n2.Return a car\n3.View available cars\n4.Exit");
            bool parsing = int.TryParse(Console.ReadLine(), out int input);
            switch (input)
            {
                case 1:
                    {
                        Console.Clear();
                        int ID = 0;
                        Console.WriteLine("Wich car do you want to rent?\n");
                        foreach (Car item in cars)
                        {
                            ID++;
                            Console.WriteLine(ID + "." + " " + item.PrintInfo());
                        }

                        Console.Write("Please enter the ID of the car you want to rent:");

                        bool rentID = int.TryParse(Console.ReadLine(), out int input2);

                        for (int i = 0; i < cars.Length; i++)
                        {
                            if (input2 - 1 == i)
                            {
                                cars[i].Rent();
                            }
                        }

                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        int ID = 0;
                        Console.WriteLine("Wich car do you want to return?\n");
                        foreach (Car item in cars)
                        {
                            ID++;
                            Console.WriteLine(ID + "." + " " + item.PrintInfo());
                        }
                        Console.Write("Please enter the ID of the car you want to rent:");

                        bool rentID = int.TryParse(Console.ReadLine(), out int input2);

                        for (int i = 0; i < cars.Length; i++)
                        {
                            if (input2 - 1 == i)
                            {
                                cars[i].Return();
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        foreach (Car item in cars)
                        {
                            Console.WriteLine(item.PrintInfo());
                        }
                        break;
                    }
                case 4:
                    {
                        exit = true;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert a valid input");
                        break;
                    }
            }
        }
    }
}