using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public virtual string SpeciesName { get; set; }
        public string Name { get; set; }
        public virtual bool Wings { get; set; }
        public virtual int Legs { get; set; }
        public virtual string Sound { get; set; }
        public virtual string sleep () {
            return "they sleeps";
        }
         public void legCount(string nickname)
        {
            Console.WriteLine($"Has 4 number of legs");
        }
        public void legCount(string nickname, int legs)
        {
            Console.WriteLine($"Has {legs} number of legs");
        }
        
    }
}    
