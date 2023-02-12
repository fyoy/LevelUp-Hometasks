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
        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Информация о вашем магазине - Наименование: {Name} , Адрес:{Address}");
        }
    }
}
