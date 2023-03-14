using System.Text.RegularExpressions;

namespace Lesson9
{
    public class NumberProcessor
    {
        public delegate void NumberEnteredEventHandler(object sender);

        public event NumberEnteredEventHandler? NumberReceivedEvent;

        public List<int>? numbers = new();

        public void RaiseEvent(string text)
        {
            string[] stringNumbers = Regex.Split(text, @"\D+");

            foreach (string value in stringNumbers)
            {
                if (int.TryParse(value, out var i))
                {
                    if (i != 0)
                    {
                        numbers.Add(i);
                    }
                }
            }
            NumberReceivedEvent?.Invoke(this);
        }
    }
}
