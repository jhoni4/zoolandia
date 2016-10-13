using System;
using Zoolandia;
// using Zoolandia.Genus;



namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args) 
        {
           Cat cat1 = new Cat("kiki", 15, 4) { 
           };
        //    Console.WriteLine(cat1.genus.genusName);
           Dog dog1 = new Dog("Bob", false, 10, 4);
           Hen hen1 = new Hen("ku", false, 2);
           Lion lion1 = new Lion("Ho", true, 4);
           Eagle eagle1 = new Eagle("Lulu", true, 2);
           Ostich ostich1 = new Ostich("kumo", true, 2);

           // Create a Domestic habitat and 
           // Create a Wild habitat 
           
            Domestic domestic = new Domestic();
            Wild wild = new Wild();

       // Create the Zoo and add all the habitats to it
           Zoo zoolandia = new Zoo();
           zoolandia.habitats.Add(domestic);
           zoolandia.habitats.Add(wild);

           domestic.inhabitants.Add(cat1);
           domestic.inhabitants.Add(dog1);
           domestic.inhabitants.Add(hen1);
           wild.inhabitants.Add(lion1);
           wild.inhabitants.Add(eagle1);
           wild.inhabitants.Add(ostich1);
           

           // Output the habitats in our Zoo
      Console.WriteLine("===================================");
           
      Console.WriteLine($"\nHABITATS in `{zoolandia.process()}`\n===================================");
      foreach(Habitat habitat in zoolandia.habitats)
      {
        Console.WriteLine($"\n{habitat.homeName}\nAnimals in this habitat:");
        foreach (Animal a in habitat.inhabitants)
        {
          Console.WriteLine($@"  Meet My friend {a.nickname} its a {a.commonName} which {a.legCount(a.legs)}   with scientific Name of {a.scientificName}
          which makes a noise that sounds like {a.sound}, Also {a.genus.Reproduce} and {a.genus.feed} if needed More info: {a.genus.url}.");
          a.sleepWay();
          a.genus.canFly(a.flying);
        }
      }
           
           Console.WriteLine("===================================");

           Console.WriteLine("THANK YOU FOR VISITING \n===================================");
           
           
        }
    }
}

            // Console.WriteLine ("Habitat: " + habitatOne.public_name);
            // foreach (Animal item in habitatOne.inhabitants)
            // {
            //       Console.WriteLine("\t" + item.IndividualName + ", a " + item.CommonName );
            // }
        //    cat1.process();
        //    dog1.process();
        //    hen1.process();
        //    lion1.process();
        //    eagle1.process();
        //    ostich1.process();
           
        //    cat1.genus.process();
        //    cat1.process("chichi", 11);
          //  dog1.legCount("lucy");
          //  cat1.process("bibi");
          //  dog1.process("bibi", 26);
          //  dog1.legCount("yona", 3);
          //  Console.WriteLine("cats walks by " + Cat.walk);