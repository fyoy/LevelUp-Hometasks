using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public sealed class Root
    {
        public int? M { get; set; }
        public int? N { get; set; }

        public void RootForRange(int M,int N)
        {
            int bigOne, smallOne;

            //При вводе отрицательного числа сбрасывает значение до 0
            if (Math.Max(M, N) < 0)//
            {
                bigOne = smallOne = 0;
                Console.WriteLine("Корни уравнения не могут принимать отрицательные значения. Поэтому числа были заменены на 0");
            }
            else
            {
                bigOne = Math.Max(M, N);

                if (Math.Min(N, M) < 0)
                {
                    smallOne = 0;
                    Console.WriteLine("Корни уравнения не могут принимать отрицательные значения. Поэтому меньшее число было заменено на 0");
                }
                else
                {
                    smallOne = Math.Min(N, M);
                }
            }

            if (bigOne > 0)
            {
                List<int> list = Enumerable.Range(smallOne, bigOne-smallOne+1).ToList();
                int cnt = 0;

                Parallel.ForEach(list, (element) =>
                {
                    for (int k = smallOne; k < list.Count; k++)
                    {
                        Interlocked.Add(ref cnt, element);
                    }
                });

                IEnumerable<int> nums =
                    from num in list.AsParallel().AsOrdered()
                    where num >= 0
                    select num;

                foreach (int num in nums)
                {
                    Console.WriteLine($"Число: {num} \t->\t Квадратный корень: {Math.Sqrt(num)}");
                } 
            }
            else
            {
                Console.WriteLine("Все числа меньше 0. Выводить нечего.");
            }
        }
    }
}
