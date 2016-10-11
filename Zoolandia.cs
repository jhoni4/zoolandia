using System;
using Zoolandia.Animals;


namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args) 
        {
           Cat mycat = new Cat("kiki", 15) {
               genus = new Mammalia() 
           };
        //    Console.WriteLine(mycat.genus.genusName);
           Dog mydog = new Dog("bob", false, 10) {
               genus = new Mammalia()
           };
           Hen myhen = new Hen("ku", false) {
               genus = new Amphibian()
           };
           Lion mylion = new Lion("ho", true) {
               genus = new Mammalia()
           };
           Eagle myeagle = new Eagle("lulu", true) {
               genus = new Amphibian()
           };
           Ostich myostich = new Ostich("kumo", true) {
               genus = new Amphibian()
           };
           


           Console.WriteLine("Here are my zoolandia collection of animals");
           mycat.process();
           mydog.process();
           myhen.process();
           mylion.process();
           myeagle.process();
           myeagle.process();
           myostich.process();
           
        //    mycat.genus.process();
        //    mycat.process("chichi", 11);
          //  mydog.legCount("lucy");
          //  mycat.process("bibi");
          //  mydog.process("bibi", 26);
          //  mydog.legCount("yona", 3);
          //  Console.WriteLine("cats walks by " + Cat.walk);
           
           
        }
    }
}
