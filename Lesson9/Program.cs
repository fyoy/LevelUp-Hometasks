using Lesson9;

//9.1
//Console.WriteLine("Введите страну:");
//var country = Console.ReadLine() ?? string.Empty;

//Console.WriteLine("Введите регион:");
//var region = Console.ReadLine() ?? string.Empty;

//Console.WriteLine("Введите город:");
//var city = Console.ReadLine() ?? string.Empty;

//Console.WriteLine("Введите индекс:");
//var index = Console.ReadLine() ?? string.Empty;

//Console.WriteLine("Введите улицу:");
//var street = Console.ReadLine() ?? string.Empty;

//Console.WriteLine("Введите номер дома:");
//var house = Console.ReadLine() ?? string.Empty;

//Console.WriteLine("Введите номер квартиры:");
//var apartment = Console.ReadLine() ?? string.Empty;

//var builder = new DeliveryAddressBuilder()
//    .WithCountry(country)
//    .WithRegion(region)
//    .WithCity(city)
//    .WithIndex(index)
//    .WithStreet(street)
//    .WithHouse(house)
//    .WithApartment(apartment);

//var address = builder.Build();

//Console.WriteLine(address);

//9.2

Console.WriteLine("Введите вашу строку с числами:");
string numbersString = Console.ReadLine() ?? string.Empty;

var processor = new NumberProcessor();

var listener = new EventListener(processor);

processor.StringToNumbers(numbersString);
