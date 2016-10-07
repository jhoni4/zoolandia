using System;
using Zoolandia.Animals;

namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args) {
            // Animal firstAnimal = new Animal();
            // firstAnimal.name = args[0].Split(new Char[] { ' ' })[0];
           Cat mycat = new Cat() {
               Name= "kitty",
               SpeciesName="cateooo",
               Wings=false,
               Legs=4,
               Sound="miaoow"
           };

           Dog mydog = new Dog() {
               Name= "bobi",
               SpeciesName="dogiieooo",
               Wings=false,
               Legs=4,
               Sound="woow"
           };
           Hen myhen = new Hen() {
               Name= "kuku",
               SpeciesName="kukiieooo",
               Wings=true,
               Legs=2,
               Sound="kukuluku"
           };
           Horse myhorse = new Horse() {
               Name= "koko",
               SpeciesName="horsieooo",
               Wings=false,
               Legs=4,
               Sound="wieeee"
           };
           mycat.process();
           mydog.process();
           myhen.process();
           myhorse.process();
           
        }
    }
}
