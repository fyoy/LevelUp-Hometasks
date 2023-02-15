using Lesson4;

var @generic = new SimpleGenericCache<string>();
var @value = "My mythical value";

@generic.Store("1", @value);

//Выведет данные для значения 1, потому что будет применен 
//стандартный таймаут в 30 секунд
var @out = @generic.Fetch("1");
Console.WriteLine(@out);

//Не выведет данные, потому что к моменту вызова
//проверки в Fetch DateTime.Now будет больше чем CreationDate
@generic.Store("2", @value,0);

@out = @generic.Fetch("2");
Console.WriteLine(@out);