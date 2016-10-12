using System;
using Zoolandia;



namespace Zoolandia
{
    class Dog: Animal
    {
        public Dog(string nickname, bool wild, int weigh) {
              this.commonName= "dog";
              this.nickname = nickname;
              this.scientificName="dogiieooo";
              this.sound="wooff";
              this.weighs=weigh;
              this.genus = new Mammalia();
           }


        // public override string sleep() {
        //   return "it sleeps by lying down.";
        // }
        // public override string feed() {
        //   return "they do breastfeed but never seen them.";
        // }
       


    }
}




