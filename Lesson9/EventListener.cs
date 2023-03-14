
namespace Lesson9
{
    public class EventListener
    {
        private List<int>? _numbers;

        public EventListener(NumberProcessor eventGenerator)
        {
            _numbers = eventGenerator.numbers;
            eventGenerator.NumberReceivedEvent += Listen1;
            eventGenerator.NumberReceivedEvent += Listen2;
        }

        private void Listen1(object sender)
        {
            int sum = 0;

            foreach (var num in _numbers)
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

        private void Listen2(object sender)
        {
            List<int>? inverted = _numbers;

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
