using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.StoreInfo.Models
{
    internal class Store
    {
        public string Name { get; }
        public string Address { get; }
        public Store(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Информация о вашем магазине - Наименование: {Name} , Адрес:{Address}");
        }
    }
}
