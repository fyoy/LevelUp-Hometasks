using System.Text.RegularExpressions;

namespace Lesson9
{
    public class NumberProcessor
    {
        public delegate void NumberEnteredEventHandler(object sender,List<int> _numbers);

        public event NumberEnteredEventHandler? NumberReceivedEvent;

        private List<int>? _numbers = new();

        public void StringToNumbers(string text)
        {
            string[] stringNumbers = Regex.Split(text, @"\D+");

            foreach (string value in stringNumbers)
            {
                if (int.TryParse(value, out var i))
                {
                    if (i != 0)
                    {
                        _numbers.Add(i);
                    }
                }
            }
            NumberReceivedEvent?.Invoke(this, _numbers);
        }
    }
}
