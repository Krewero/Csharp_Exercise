using Char;

public class Warrior: Character
{
    public Warrior(string Name, int Health, int Attack, int Defense) : base(Name, Health, Attack, Defense)
    {
    }

    public void Charge(Character target)
    {
        int damage = 30;
        int damageToHealth = damage - target.Defense;
        if(damageToHealth > 0)
        {
            target.Health = target.Health -damageToHealth;
            Console.WriteLine($"{this.Name} charge {target.Name} for {damageToHealth} damage");
        }
        else if(damageToHealth <= 0)
        {
            Console.WriteLine("The charge have no effect");
        }
    }

    public override sealed void Defend()
    {
        int defenseMethod = 5;
        this.Defense = this.Defense + defenseMethod;
        Console.WriteLine($"{this.Name} defends and gains {defenseMethod} defens");
    }
}