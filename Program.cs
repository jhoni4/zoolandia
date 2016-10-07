using System;
using Zoolandia.Animals;


namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args) {
           Cat mycat = new Cat("kit");
           Dog mydog = new Dog("bob");
           Hen myhen = new Hen("ku", 2);
           Horse myhorse = new Horse("ho");
           mycat.process();
           mydog.process();
           myhen.process();
           myhorse.process();
        //    Animal.legCount("yona", 1000);
           
        }
    }
}
