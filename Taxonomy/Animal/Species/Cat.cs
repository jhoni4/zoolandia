using System;
using Zoolandia;


namespace Zoolandia
{
   public class Cat: Animal
    {
       public Cat(string nickname, int weigh) {
           this.commonName = "cat";
           this.nickname = nickname;
           this.scientificName = "catieeo";
           this.weighs=weigh;
           this.sound="miaww";
           this.genus = new Mammalia();
       } 
       

       public string walk= "walking";
       



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
        // public override string sleepWay() {
        //   return "it sleeps by lying down.";
        // }
        // public override string feed() {
        //   return "they do breastfeed.";
        // }
         