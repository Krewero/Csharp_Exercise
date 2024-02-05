using Library;
using System;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the library!!");
        Console.WriteLine("");

        Book book = new Book("Virgina Woolf", "Kew Gardens", "123456789LI");
        CD cd = new CD("Bob Dylan", "Blonde on Blonde", 8);
        DVD dvd = new DVD("Peter Jackson", "Hobbit", 200);

        bool exit = false;
        while (exit == false)
        {
            Console.WriteLine("Please choose an item to borrow:\n1.Book\n2.CD\n3.DVD\n4.Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        while (book.LoanPeriod == 0)
                        {
                            Console.WriteLine("This is the book:" + " " + book.Print());
                            Console.WriteLine("Please write the number of days you want to borrow the book:");
                            int days = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(book.Borrow(days));
                        }
                        break;

                    }
                case 2:
                    {
                        while (cd.LoanPeriod == 0)
                        {
                            Console.WriteLine("This is the CD:" + " " + cd.Print());
                            Console.WriteLine("Please write the number of days you want to borrow the cd:");
                            bool days = int.TryParse(Console.ReadLine(), out int numberOfDays);
                            Console.WriteLine(cd.Borrow(numberOfDays));
                        }
                        break;
                    }
                case 3:
                    {
                        while (dvd.LoanPeriod == 0)
                        {
                            Console.WriteLine("This is the DVD:" + " " + dvd.Print());
                            Console.WriteLine("Please write the number of days you want to borrow the DVD:");
                            bool days = int.TryParse(Console.ReadLine(), out int numberOfDays);
                            Console.WriteLine(dvd.Borrow(numberOfDays));
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
                        Console.WriteLine("Please enter a valid input");
                        break;
                    }
            }
        }
    }
}
