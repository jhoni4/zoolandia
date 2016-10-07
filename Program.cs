using System;
using Zoolandia.Animals;

namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args) {
           Cat mycat = new Cat() {
               Name= "kitty",
               SpeciesName="cateooo",
               Legs=4,
               Sound="miaoow"
           };
           Dog mydog = new Dog() {
               Name= "boby",
               SpeciesName="dogiieeeooo",
               Legs=4,
               Sound="wofff"
           };
           Hen myhen = new Hen() {
               Name= "kuku",
               SpeciesName="henieooo",
               Legs=2,
               Sound="kukulu"
           };
           Horse myhorse = new Horse() {
               Name= "koko",
               SpeciesName="kokieooo",
               Legs=4,
               Sound="wiieee"
           };
           Console.WriteLine(mycat.inform());
           Console.WriteLine(mydog.inform());
           Console.WriteLine(myhen.inform());
           Console.WriteLine(myhorse.inform());
           
           
        }
    }
}
