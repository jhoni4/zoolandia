using System;

namespace Zoolandia.Animals
{
   public class Animal
    {
        public string scientificName { get; set; }
        public string commonname { get; set; }
        public bool Wings { get; set; }
        public bool Domestic { get; set; }
        public int Legs { get; set; }
        public string Sound { get; set; }
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
