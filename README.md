# zoolandia
Zoolandia - Specializing Derived Classes

Setup

cd ~/workspace/zoolandia
git checkout -b version-2
Instructions

Virtual/Override

Choose one of the general methods that you created in the Animal class and make it virtual.
Override that method in all of your species classes, giving each a more specialized implementation. For example, the species may only eat certain kinds of food, or have a limit on how much food can be eaten.
Make sure you invoke the parent class' overridden method with the base reference (e.g. base.sleep());
Constructors

Create a constructor function for each of your animals. The constructor function should, at the very least, set the initial name of all animals of that type to a name of your choosing.

public MyAnimal ()
{
  this.name = "Moopsie";
}
Use Console.WriteLine(); to output the name of each of your animal instances.

MyAnimal animalInstance = new MyAnimal();
Console.WriteLine(animalInstance.name);