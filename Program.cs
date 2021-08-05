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


            
            Console.WriteLine(ninja1.Name);
        }
    }
}
