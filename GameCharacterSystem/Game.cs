using Char;

public class Game
{
    public void Battle(Character c1, Character c2)
    {
        if (c1.Health > 0 && c2.Health > 0)
        {
            Console.WriteLine($"The battle between {c1.Name} and {c2.Name} begins!");

            while (c1.Health != 0 || c2.Health != 0)
            {

                bool warriorMove = false;
                int input;
                do
                {

                    if (c1 is Warrior)
                    {
                        Console.WriteLine($"{c1.Name} choose your next move:\n1.Attack\n2.Special Attack\n3.Defense");
                    }
                    else
                    {
                        Console.WriteLine($"{c1.Name} choose your next move:\n1.Attack\n2.Special Attack");
                    }

                    input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            {
                                c1.AttackMove(c2);
                                Console.WriteLine($"The current Health of {c2.Name} is: {c2.Health}");
                                break;
                            }
                        case 2:
                            {
                                if (c1 is Warrior)
                                {
                                    Warrior warC1 = (Warrior)c1;
                                    warC1.Charge(c2);
                                    Console.WriteLine($"The current Health of {c2.Name} is: {c2.Health}");
                                }
                                else if (c1 is Mage)
                                {
                                    Mage magC1 = (Mage)c1;
                                    magC1.CastSpell(c2);
                                    Console.WriteLine($"The current Health of {c2.Name} is: {c2.Health}");
                                }
                                else if (c1 is Dragon)
                                {
                                    Dragon drgC1 = (Dragon)c1;
                                    drgC1.BreatheFire(c2);
                                    Console.WriteLine($"The current Health of {c2.Name} is: {c2.Health}");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (c1 is Warrior)
                                {
                                    warriorMove = true;
                                    Warrior warC1 = (Warrior)c1;
                                    warC1.Defend();
                                    Console.WriteLine($"The current Defense of {warC1.Name} is: {warC1.Defense}");
                                }
                                else
                                {
                                    Console.WriteLine("This move doesen't exist");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("This move dosn't exist");
                                break;
                            }
                    }
                } while (input != 1 && input != 2 && warriorMove == false);


                int input2;
                bool warriorMove2 = false;

                do
                {

                    if (c2 is Warrior)
                    {
                        Console.WriteLine($"{c2.Name} choose your next move:\n1.Attack\n2.Special Attack\n3.Defense");
                    }
                    else
                    {
                        Console.WriteLine($"{c2.Name} choose your next move:\n1.Attack\n2.Special Attack");
                    }

                    input2 = Convert.ToInt32(Console.ReadLine());
                    switch (input2)
                    {
                        case 1:
                            {
                                c2.AttackMove(c1);
                                Console.WriteLine($"The current Health of {c1.Name} is: {c1.Health}");
                                break;
                            }
                        case 2:
                            {
                                if (c2 is Warrior)
                                {
                                    Warrior warc2 = (Warrior)c2;
                                    warc2.Charge(c1);
                                    Console.WriteLine($"The current Health of {c1.Name} is: {c1.Health}");
                                }
                                else if (c2 is Mage)
                                {
                                    Mage magc2 = (Mage)c2;
                                    magc2.CastSpell(c1);
                                    Console.WriteLine($"The current Health of {c1.Name} is: {c1.Health}");
                                }
                                else if (c2 is Dragon)
                                {
                                    Dragon drgc2 = (Dragon)c2;
                                    drgc2.BreatheFire(c1);
                                    Console.WriteLine($"The current Health of {c1.Name} is: {c1.Health}");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (c2 is Warrior)
                                {
                                    warriorMove2 = true;
                                    Warrior warc2 = (Warrior)c2;
                                    warc2.Defend();
                                    Console.WriteLine($"The current Defense of {warc2.Name} is: {warc2.Defense}");
                                }
                                else
                                {
                                    Console.WriteLine("This move doesen't exist");
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("This move dosn't exist");
                                break;
                            }
                    }
                } while (input != 1 && input != 2 && warriorMove2 == false);
            }
        }

    }
}