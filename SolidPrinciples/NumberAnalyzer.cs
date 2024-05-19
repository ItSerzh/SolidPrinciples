using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class NumberAnalyzer
    {
        private readonly int _required;
        private readonly int _attemptsCount;

        public NumberAnalyzer(int required, int attemptsCount)
        {
            _required = required;
            _attemptsCount = attemptsCount;
        }

        public string AnalyzeVal (int supposed)
        {
            if (supposed > _required)
            {
                return "Provided value is greater then required";
            }

            if (supposed < _required)
            {
                return "Provided value is less then required";
            }

            return "Cngradulations! You win!";

        }

        public string AnalyzeAttempts(int attempNumber)
        {
            var difference = _attemptsCount - attempNumber;
            if (difference > 0)
            {
                return $"You have {difference} attempts count.";
            }

            return "You have no attempts any more.";

        }
    }
}
