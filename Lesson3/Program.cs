using Lesson3;

Console.WriteLine("Clothes part");
var cl = new Clothes();

cl.showFullInfo();

Console.WriteLine("\nEquipments part");
var eq = new Equipment();
eq.showFullInfo();

Console.WriteLine("\nFood part");
var fd = new Food();
fd.showFullInfo();

Console.WriteLine("\nDerived from Food class Bar");
var bar=new Bar();
bar.showFullInfo();
bar.addSomeSeeds();
bar.showFullInfo();

Console.ReadLine();