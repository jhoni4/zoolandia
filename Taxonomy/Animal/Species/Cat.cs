using System;
using Zoolandia;


namespace Zoolandia
{
   public class Cat: Animal
    {
       public Cat(string nickname, int weigh, int legs) {
           this.commonName = "cat";
           this.nickname = nickname;
           this.legs = 4;
           this.scientificName = "catieeo";
           this.weighs=weigh;
           this.sound="miaww";
           this.genus = new Mammalia();
       } 
       

       public string walk= "walking";
       
        public override void sleepWay() {
          Console.WriteLine("it sleeps by lying down.");
        }
         public override void food() {
          Console.WriteLine("usually they drink milk.");
        }
        



    }
}








       
    //    public void eat()
    //     {
    //         if (food == null)
    //         {
    //             Console.WriteLine("No food provided yet");
    //         }
    //     }
        // private int _age=20;
        // public int age{
        //     get{
        //         return _age;
        //     }
        // }
         