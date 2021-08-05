using System;

namespace WizNinSam
{
    public class Ninja : Human
    {
       public Ninja (string name) :base(name)
       {
           Name = name;
           Dexterity = 175;
       }

        public int Steal(Human target)
    {
        int dmg = 5;
        target.Health = dmg;
        this.Health = dmg;
        Console.WriteLine($"Here is my trap card");
        return target.Health;
    }



    public new int Attack(Human target)
    {   
        Random rand = new Random();

        int dmg = Dexterity * 3;
        target.Health -= dmg;
        if (rand.Next(1,9) == 2) 
        {
            target.Health -= 10;
        }
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    } 
    }
}