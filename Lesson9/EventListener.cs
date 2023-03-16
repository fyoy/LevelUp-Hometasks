
namespace Lesson9
{
    public class EventListener
    {
        public EventListener(NumberProcessor eventGenerator)
        {
            eventGenerator.NumberReceivedEvent += Listen1;
            eventGenerator.NumberReceivedEvent += Listen2;
        }

        private void Listen1(object sender, List<int> numberList)
        {
            int sum = 0;

            foreach (var num in numberList)
            {
                sum += num;
            }

            if (sum == 0)
            {
                Console.WriteLine("Слушатель №1 считает что чисел в данной строке нет.");
            }
            else
            {
                Console.WriteLine($"Слушатель №1 вычислил сумму всех чисел и она равна = {sum}");
            }
        }

        private void Listen2(object sender, List<int> numberList)
        {
            List<int>? inverted = numberList;

            if(inverted.Count == 0)
            {
                Console.WriteLine("Слушатель №2 считает что чисел в данной строке нет.");
            }
            else
            {
                inverted?.Reverse();

                foreach (var num in inverted)
                {
                    Console.Write($"{num} ");
                }
            }
        }

    }
}
