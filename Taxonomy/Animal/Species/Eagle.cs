using System;


namespace Zoolandia
{
    class Eagle: Animal
    {
        public Eagle(string nickname, bool flying) {
               this.commonName= "Eagle";
               this.nickname= nickname;
               this.scientificName="Eaglieooo";
               this.flying=true;
               this.sound="ikiki";
               this.genus = new Amphibian();
        }
        // public Genus genus= new Amphibian();

        // public override string sleep() {
        //   return "it sleeps by siting down.";
        // }


    }
}




