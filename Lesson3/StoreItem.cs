namespace Lesson3
{
    interface IFullInfo
    {
        void showFullInfo();
    }
    interface IExpiration
    {
        public DateTime deliveryTime { get; set; }
        public DateTime expirationDate { get; set; }
        void setCount();
    }
    public class StoreItem //Главный родительский класс
    {
        public string? name { get; set; }//Наименование товара
        public string? price { get; set; }//Цена товара
        public bool? isPresented { get; set; } //В наличии в магазине

    }
    public class Clothes : StoreItem, IFullInfo, IExpiration //Одежда
    {
        private string[] _sizes { get; } = { "XL", "L", "M", "S", "FAT" };
        public string? size { get; init; }
        public DateTime deliveryTime { get; set; } = DateTime.Now;
        public DateTime expirationDate { get; set; }
        public Clothes()
        {
            name = "Clothes";
            var _ = new Random();
            size = _sizes[_.Next(0, _sizes.Length)];
            setCount();
        }
        public void setCount()//Назначение времени, после которого будет действовать скидка
        {
            expirationDate = deliveryTime.AddDays(365);
        }
        public void showFullInfo()
        {
            Console.WriteLine($"Discount for this item is going to be on {expirationDate}, buy now with full price or wait.\nThis item is wearable and have size:{size}, if it's FAT u should start to exercise :(");
            if ( size  != "FAT")
            {
                Console.WriteLine("Luckily, you are not fat:) ");
            }
            else
            {
                Console.WriteLine("Unfortunately, you are as big as truck:(");
            }
        }
    }
    public class Equipment : StoreItem, IFullInfo, IExpiration
    {
        private string[] sportTypes { get; } = { "Soccer", "Swimming", "Basketball","Etc." };
        public string? sportType { get; set; }
        public DateTime deliveryTime { get; set; } = DateTime.Now;
        public DateTime expirationDate { get; set;}

        public Equipment()
        {
            name = "Equipment";
            setCount();
        }
        public void setCount()
        {
            expirationDate = deliveryTime.AddDays(730);
        }
        public void showFullInfo()
        {
            Console.WriteLine($"This item is {name}.Discount for this item is going to be on {expirationDate}. \r\nGuess a number from 1 to 3: ");

            var _ = Console.ReadLine();
            switch (_)
            {
                case "1":
                    Console.WriteLine("You are a born football player.");
                    sportType = sportTypes[0];
                    break;
                case "2":
                    Console.WriteLine("You are a born swimmer.");
                    sportType = sportTypes[1];
                    break;
                case "3":
                    Console.WriteLine("You are a born basketball player.");
                    sportType = sportTypes[2];
                    break;
                default:
                    Console.WriteLine("You have not talent. Live with it.");
                    sportType = sportTypes[3];
                    break;
            }
        }
    }
    public class SwimmingGlasses:Equipment
    {
        public bool? isWithSuctionCups { get; set; } = true;

    }
    public class  Food: StoreItem, IFullInfo, IExpiration
    {
        private string[] _containsTheMost { get; } = { "fat", "protein", "carbohydrates" };
        public string energyFrom { get; set; }
        public DateTime deliveryTime { get ; set ; } = DateTime.Now;
        public DateTime expirationDate { get; set; }

        public Food()
        {
            name = "Food";
            var _ = new Random();
            energyFrom = _containsTheMost[_.Next(0,2)]; 
            setCount();
        }
        public void setCount()
        { 
            expirationDate = deliveryTime.AddDays(31);
        }
        public void showFullInfo()
        { 
            Console.WriteLine($"This food will begin rot in {expirationDate}. But before that u should know that it mostly contains - {energyFrom}.");
        }
    }
    public class Bar : Food
    {
        public bool? isWithSeeds { get; set; } = false;
        public void addSomeSeeds()
        {
            isWithSeeds = true;
            Console.WriteLine("\n***Adding some seeds***");
            Console.Write(",,,,,,...........,,.............,,,,,,,**,***,,*****,,***********\r\n               ,,,,,,,.........,,.,#/##*,..........,,,,,****,,****,,,***********\r\n.....       .  ,,,,,,,...........*..,**#@#...,......,,,,****,,****,,,***********\r\n (......  .....,,,,,,,...........,,.,*/(#&@/,.......,,,,*,**,,,***,,,***********\r\n....... .....,/*,//#/,..........,,,...,/#%&(/,,.....,,,,,***,,,***,,,***,*******\r\n  .....*/(.../***/////.......,,***,,....#%%//,,,....,,,,,,,*,,,***,,,*********,,\r\n       .,/////****/*//.,....,,********,,,(%/*..,.,..,,,,,,,*,,,,*,,,,,,,,,,***,*\r\n        ..*/(/****//(//,,.,,,,*************/,,....,,,,,,,,**,,,,,,,,,,,,,,,,**,,\r\n        ...,///((((//(/.*,,,,,..,**********,.,....,,,,,,,,,,,,,,,,,,,,,*,,,,**,,\r\n.   .  ......,*/((((//*..,,,,.....,*,,,,(%&,.,.....,,,,,,,,,,,,,,,,,,,,,,,,,,*,,\r\n..............**////**...,,,,,,,,,**,...,,..,,.....,,,,,,,,,,,,,,,,,,,,,,,,,**,,\r\n...............***(((*.,*,,,,,,,*******##%%%%#,....,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n...............,,*(#(((#/,,,,,,,,,,,,,((/%###%%%...,,,,,,,,,,,,,,,,,,,,,,,,,,,,,\r\n,...,..%#&.....,*,**//((((((,,,,,,,,,*(((((%&%%%*..,,,,,,,,,,,,,,,,,,*,,,,,,,,,,\r\n..............*,****///(((((////,******/((((*&&&#,,,,,,,,,,,,,,,,,,,,,***,**,,,,\r\n.............##,*****//((#######%%%///////(//*&&&,,,,,,,,,,,,***********,,,,,,,,\r\n............(#(,*****//(#&@@%%&&&%###&%***//(%%%%(,,,,,,,,,,,.,,,,,,,,,,,,,..,..\r\n............##*,******//(#&@@&%%%%#&@%#####%#%%%%%,,..,,,,,,,,,,,,,,,,,,,,,.....\r\n.............(,,,*****////#&&#%%###%###%%%#####%%%*,....,,,,,,,,,,,,,,,.........\r\n.............*,,*****/////(%&#(##%####%##########**,.........,,,,...............\r\n...............,%,**/////(#%&((&%###%###########%,**...,,.......................\r\n................,,,**///#&%%&((((((##############/,*,...........................\r\n.................,,********/((((#(((############%%,,*.....,.....................\r\n.....  ..........,,,//((((((((((((((##############,,*,................ .........\n");
        }
        public new void showFullInfo()
        {
            base.showFullInfo();
            if (isWithSeeds == true)
            {
                Console.WriteLine($"But also this bar is probably with seeds.");
            }
            else
            {
                Console.WriteLine("This bar doesnt containt seed.");
            }
        }
    }
}