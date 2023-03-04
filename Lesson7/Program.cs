using Lesson7;

/*
 Задание 7.1
 Заполнять границы можно в любом порядке
 */
var example = new Root();

Console.Write("Введите M: ");

var stringM = Console.ReadLine() ?? string.Empty;

var M = int.Parse(stringM);

Console.Write("Введите N: ");

var stringN = Console.ReadLine() ?? string.Empty;

var N = int.Parse(stringN);

example.RootForRange(N, M);

/*
 Задание 7.2
 
 */

var example2 = new Monster();

await example2.CreateMonster();
await example2.CreateMonster();

Console.ReadKey();