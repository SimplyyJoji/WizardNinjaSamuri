using System;

namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja1 = new Ninja("Ninja");
            Samuri samuri1 = new Samuri("Samuri");
            Wizard wizard1 = new Wizard("Wizard");
            ninja1.Attack(samuri1);
            samuri1.Meditate(samuri1);
            wizard1.Attack(ninja1);

            Console.WriteLine(ninja1.Name);
        }
    }
}
