using System;
using Zoolandia;



namespace Zoolandia
{
    class Dog: Animal
    {
        public Dog(string nickname, bool wild, int weigh) {
              this.commonName= "dog";
              this.nickname = nickname;
              this.legs = 4;
              this.scientificName="dogiieooo";
              this.sound="wooff";
              this.weighs=weigh;
              this.genus = new Mammalia();
           }


        public override void sleepWay() {
           Console.WriteLine("it sleeps by lying down.");
        }
        public override void food() {
          Console.WriteLine("usually they eat meat.");
        }
       


    }
}




