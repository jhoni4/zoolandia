using System;

namespace Zoolandia
{
  public class Genus : IGenus
  {
         public string feed{get; set;}
         public string Reproduce{get; set;}
         public string genusName {get; set;}
         public string commonName {get; set;}
         public string scientificName {get; set;}
         public string food {get; set;}
         public string sound {get; set;}
         public string walky {get; set;}
         public string url {get; set;}
         public virtual void canFly(bool flying) {}
         
         public Genus genus
         {
           get; set;
         }
          //overloading
         public void process1(string genusName) {
              Console.WriteLine($"I have genus Name of {this.genusName}");
        }

         
         
  }
}