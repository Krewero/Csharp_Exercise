namespace Char
{
    public abstract class Character
    {
        private string _name;
        private int _health;
        private int _attack;
        private int _defense;

        public string Name 
        {
            get {return _name;}
            set
            {
                if(value.Length > 2)
                {
                    _name = value;
                }
            }
        }

        public int Health
        {
            get {return _health;}
            set
            {
                _health = value;
            }
        }

        public int Attack 
        {
            get {return _attack;}
            set 
            {
                if(value >= 10)
                {
                    _attack = value;
                }
            }
        }

        public int Defense 
        {
            get {return _defense;}
            set 
            {
                if(value >= 10)
                {
                    _defense = value;
                }
            }
        }

        public Character(string Name, int Health, int Attack, int Defense)
        {
            this.Name = Name;
            this.Health = Health;
            this.Attack = Attack;
            this.Defense = Defense;
        }

        public void AttackMove(Character target)
        {
            int damage = this.Attack - target.Defense;
            if(damage > 0)
            {
                target.Health = target.Health - damage;
                Console.WriteLine($"{this.Name} attacks {target.Name} for {damage} damage!");
            }
            else if(damage <= 0)
            {
                Console.WriteLine($"The attacks have no offect to {target.Name}");
            }
        }

        public virtual void Defend()
        {
            Console.WriteLine(this.Defense);
        }
    }
}