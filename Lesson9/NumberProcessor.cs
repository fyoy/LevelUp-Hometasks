using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson9
{
    public class NumberProcessor
    {
        public delegate void NumberEneteredEventHandler(object sender);

        public event NumberEneteredEventHandler? NumberReceivedEvent;

        public List<int>? numbers = new();
        public NumberProcessor(string text)
        {
            string[] stringNumbers = Regex.Split(text, @"\D+");
            foreach (string value in stringNumbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    if (i != 0)
                    {
                        numbers.Add(i);
                    }
                }
            }
        }
        public virtual void RaiseEvent()
        {
            NumberReceivedEvent?.Invoke(this);
        }
    }
    public sealed class EventListener
    {
        private readonly int _listenerId;
        private List<int>? _numbers;

        public EventListener(NumberProcessor eventGenerator, int listenerId)
        {
            _listenerId = listenerId;
            _numbers = eventGenerator.numbers;
            eventGenerator.NumberReceivedEvent += Listen;
        }

        private void Listen(object sender)
        {
            if(_listenerId == 1)
            {
                int sum = 0;

                foreach (var num in _numbers)
                {
                    sum += num;
                }

                if(sum == 0)
                {
                    Console.WriteLine("Слушатель №1 считает что чисел в данной строке нет.");
                }else
                {
                    Console.WriteLine($"Слушатель №1 вычислил сумму всех чисел и она равна = {sum}");

                }
            }
            if(_listenerId == 2)
            {
                List<int>? inverted = _numbers;
                inverted?.Reverse();

                foreach(var num in inverted)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }

}
