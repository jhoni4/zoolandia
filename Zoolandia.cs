using System;

namespace Zoolandia
{
    public class Animal
    {
        public virtual string SpeciesName { get; set; }
        public string Name { get; set; }
        public virtual bool Wings { get; set; }
        public virtual int Legs { get; set; }
        public virtual string Sound { get; set; }
        public static void sleep () {
            Console.WriteLine("Animal is now sleeping");
        }
        
    }
}    