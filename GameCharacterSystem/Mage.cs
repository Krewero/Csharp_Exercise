using Char;

public class Mage: Character
{
    public Mage(string Name, int Health, int Attack, int Defense) : base(Name, Health, Attack, Defense)
    {
    }

    public void CastSpell(Character target)
    {
        int spellDamage = 30;
        int damageToHealth = spellDamage - target.Defense;
        if(damageToHealth > 0)
        {
            target.Health = target.Health - damageToHealth;
            Console.WriteLine($"{this.Name} throw a spell to {target.Name} for {damageToHealth} damage");
        }
        else if(damageToHealth < 0)
        {
            Console.WriteLine("This spell have no effect");
        }
    }
}