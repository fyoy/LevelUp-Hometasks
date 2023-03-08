using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.IO.Pipes;

namespace Lesson7
{
    public class Monster
    {
        public string Path { get; set; }

        public Monster()
        {
            Console.WriteLine("Введите путь:");
            Path = Console.ReadLine() ?? string.Empty;
        }

        public async Task CreateMonster()
        {
            string monsterPath = Path + "Монстр_под_номером_[" + Guid.NewGuid().ToString() + "].txt";

            try
            {
                DirectoryInfo directory = new(Path);
                int counter = 0;

                foreach(var file in directory.GetFiles())
                {
                    string fullName = System.IO.Path.Combine(Path, file.Name);

                    using FileStream fileStream = new(monsterPath, FileMode.Append);  
                    using FileStream fileStreamRead = new(fullName, FileMode.Open);

                    byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                    byte[] buffer = new byte[fileStreamRead.Length];

                    await fileStreamRead.ReadAsync(buffer);

                    if (counter!=0)
                    {
                        await fileStream.WriteAsync(newline);
                    }

                    await fileStream.WriteAsync(buffer);

                    Console.WriteLine($"Текст из файла {fullName} записан.");
                    counter++;
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Данного пути не существует.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
