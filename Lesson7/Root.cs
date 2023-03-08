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
            try
            {
                int bigOne, smallOne;

                //При вводе отрицательного числа сбрасывает значение до 0
                if (M < 0 || N <0)//
                {
                    throw new Exception("Оба числа должны быть положительными.");
                }
                else
                {
                    bigOne = Math.Max(M, N);
                    smallOne= Math.Min(M, N);
                }

                List<int> list = Enumerable.Range(smallOne, bigOne - smallOne + 1).ToList();
                int cnt = 0;
                
                IEnumerable<int> nums =
                    from num in list.AsParallel().AsOrdered()
                    where num >= 0
                    select num;
                
                foreach (int num in nums)
                {
                    Console.WriteLine($"Число: {num} \t->\t Квадратный корень: {Math.Sqrt(num)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
