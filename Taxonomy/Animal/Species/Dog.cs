using System;


namespace Zoolandia.Animals
{
    class Dog: Animal
    {
        public Dog(string nickname, bool wild, int weigh) {
              this.commonName= "dog";
              this.nickname = nickname;
              this.scientificName="dogiieooo";
              this.Domestic=true;
              this.sound="wooff";
              this.weighs=weigh;
           }
        // public override string sleep() {
        //   return "it sleeps by lying down.";
        // }
        // public override string feed() {
        //   return "they do breastfeed but never seen them.";
        // }
       


    }
}




