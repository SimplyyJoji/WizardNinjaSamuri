using System;

namespace WizNinSam
{
    public class Samuri : Human
    {
        public Samuri (string name) :base(name)
        {
            Name = name;
            Health = 200;
        }
        public int Meditate(Samuri Health)
    {

        this.Health = 200;
        Console.WriteLine($"Saw flashback as child now health is {this.Health}");
        return this.Health;
    }


        public new int Attack(Human target)
    {   
        
        int dmg = Strength * 3;
        target.Health -= dmg;
        if (target.Health < 50) 
        {
            target.Health = 0;
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}
}