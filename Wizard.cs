using System;

namespace WizNinSam
{
    public class Wizard : Human
    {
       public Wizard (string name) :base(name)
       {
           Name = name;
           Intelligence = 25;
           Health = 50;
       } 


    public int Heal(Human target)
    {
        int heal = Intelligence * 5;
        target.Health += heal;
        Console.WriteLine($"I healed for {heal} for a cost.");
        return target.Health;
    }
        public new int Attack(Human target)
    {   
        
        int dmg = Intelligence * 5;
        target.Health -= dmg;
        int heal = dmg;
        this.Health += heal;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    } 
    }
}
