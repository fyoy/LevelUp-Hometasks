using Lesson2;
using Lesson2.StoreInfo.Models;

//******************************Задание 11***************************

Console.WriteLine("Введите наименование вашего магазина: ");
var StoreName = Console.ReadLine();

if (string.IsNullOrEmpty(StoreName))
{
    Console.WriteLine("Не удалось записать наименование. Попробуйте снова:");
    StoreName = Console.ReadLine();
}

Console.WriteLine("Введите адрес вашего магазина: ");

var StoreAddress = Console.ReadLine();

if (string.IsNullOrEmpty(StoreAddress))
{
    Console.WriteLine("Не удалось записать адрес. Попробуйте снова:");
    StoreAddress = Console.ReadLine();
}

Store mystore = new Store(StoreName, StoreAddress);

mystore.PrintInfo();

//***************************Задача по карточке человека************************

string Name, Surname, Hobby;
int Age;

Console.Write("Введите ваши данные:\nИмя:");
while (string.IsNullOrEmpty(Name = Console.ReadLine() ?? string.Empty)) { Console.Write("Вы не ввели значения. Пожалуйста, введите имя: "); }

Console.Write("Фамилия:");
while (string.IsNullOrEmpty(Surname = Console.ReadLine() ?? string.Empty)) { Console.Write("Вы не ввели значения. Пожалуйста, введите фамилию: "); }

Console.Write("Возраст:");
while (!int.TryParse(_ = Console.ReadLine() ?? string.Empty, out Age) || Age > 150)
{
    if (Age > 150) { Console.Write("Возраст похож на библейский. Пожалуйста, введите возраст в виде числа меньше 150 лет: "); }
    else { Console.Write("Вы неверно указали значение. Пожалуйста, введите возраст в виде числа: "); }
}

Console.Write("Увлечение:");
while (string.IsNullOrEmpty(Hobby = Console.ReadLine() ?? string.Empty)) { Console.Write("Вы не ввели значения. Пожалуйста, введите увлечение: "); }

Console.WriteLine($"\nВведенные данные: \n\tИмя: {Name}\n\tФамилия: {Surname}\n\tВозраст: {Age}\n\tУвлечение: {Hobby}");

