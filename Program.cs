using System;
using Zoolandia.Animals;


namespace zoolandia
{
    public class Program
    {
        public static void Main(string[] args) {
           Cat mycat = new Cat("kit", false);
           Dog mydog = new Dog("bob", false);
           Hen myhen = new Hen("ku", 2);
           Lion mylion = new Lion("ho", true);
           Eagle myeagle = new Eagle("ho", 2);
           mycat.process();
           mycat.process("bibi");
           mydog.process();
           myhen.process();
           mylion.process();
           myeagle.process();
        //    mycat.legCount("yona", 1000);
           
        }
    }
}
