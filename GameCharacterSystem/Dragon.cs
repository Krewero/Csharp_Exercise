using Char;

public class Dragon: Character
{
    public Dragon(string Name, int Health, int Attack, int Defense) : base(Name, Health, Attack, Defense)
    {
    }

    public void BreatheFire(Character target)
    {
        int damage = 50;
        int damageToHealth = damage - target.Defense;
        if(damageToHealth > 0)
        {
            target.Health = target.Health - damageToHealth;
            Console.WriteLine($"{this.Name} breathe fire to {target.Name} for {damageToHealth} damage");
        }
        else if(damageToHealth <= 0)
        {
            Console.WriteLine("This attack have no effect");
        }
    }
}