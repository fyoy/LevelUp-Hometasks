using Lesson2;
using Lesson2.StoreInfo.Models;

//******************************Задание 11***************************

Console.WriteLine("Введите наименование вашего магазина: ");
var storeName = Console.ReadLine();

while (string.IsNullOrEmpty(storeName))
{
    Console.WriteLine("Не удалось записать наименование. Попробуйте снова:");
    storeName = Console.ReadLine();
}

Console.WriteLine("Введите адрес вашего магазина: ");

var storeAddress = Console.ReadLine();

while (string.IsNullOrEmpty(storeAddress))
{
    Console.WriteLine("Не удалось записать адрес. Попробуйте снова:");
    storeAddress = Console.ReadLine();
}

Store mystore = new Store(storeName, storeAddress);

mystore.PrintInfo();

//***************************Задача по карточке человека************************

Console.Write("Введите ваши данные:\nИмя:");

var name = Console.ReadLine();
while (string.IsNullOrEmpty(name))
{ 
    Console.Write("Вы не ввели значения. Пожалуйста, введите имя: ");
    name = Console.ReadLine();
}

Console.Write("Фамилия:");

var surname = Console.ReadLine();
while (string.IsNullOrEmpty(surname)) 
{ 
    Console.Write("Вы не ввели значения. Пожалуйста, введите фамилию: ");
    surname = Console.ReadLine();
}

Console.Write("Возраст:");

int age;
var ageString = Console.ReadLine() ?? string.Empty;
while (!int.TryParse(ageString,out age) || age > 150 || 0 > age )
{
    if (age > 150)
    {
        Console.Write("Возраст похож на библейский. Пожалуйста, введите возраст в виде числа меньше 150 лет: ");
        ageString = Console.ReadLine();
    }
    if(age < 0)
    {
        Console.Write("С вашим возрастом можно быть только в планах. Введите существующий возраст: ");
        ageString = Console.ReadLine();
    }
    else
    { 
        Console.Write("Вы неверно указали значение. Пожалуйста, введите возраст в виде числа: ");
        ageString = Console.ReadLine();
    }
}

Console.Write("Увлечение:");
var hobby = Console.ReadLine();
while (string.IsNullOrEmpty(hobby)) 
{ 
    Console.Write("Вы не ввели значения. Пожалуйста, введите увлечение: ");
    hobby = Console.ReadLine();
}

Console.WriteLine($"\nВведенные данные: \n\tИмя: {name}\n\tФамилия: {surname}\n\tВозраст: {age}\n\tУвлечение: {hobby}");