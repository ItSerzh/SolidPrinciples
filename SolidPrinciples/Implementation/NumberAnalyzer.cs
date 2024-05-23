using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    internal class NumberAnalyzer(IOutput output, IInput input, IConfigurationReader cfgReader, INumberGenerator generator) : INumberAnalyzer
    {
        private readonly IInput _input = input;
        private readonly IOutput _output = output;
        private readonly int _requiredNumber = generator.GetRandomInt();
        private readonly int _attemptsCount = cfgReader.GetAttemptsCount();

        private string AnalyzeVal(int supposed)
        {
            if (supposed > _requiredNumber)
            {
                return "Provided value is greater then required";
            }

            if (supposed < _requiredNumber)
            {
                return "Provided value is less then required";
            }

            return "Cngradulations! You win!";
        }

        private string AnalyzeAttempts(int attempNumber)
        {
            var difference = _attemptsCount - attempNumber;
            if (difference > 0)
            {
                return $"You have {difference} attempts count.";
            }

            return "You have no attempts any more.";
        }

        public void AnalyzeNumber()
        {
            for (int i = 1; i <= _attemptsCount; i++)
            {
                _output.WriteLine("Enter your number:");
                var supposed = Convert.ToInt32(_input.ReadLine());
                _output.WriteLine(AnalyzeVal(supposed));
                if (supposed == _requiredNumber)
                {
                    break;
                }
                _output.WriteLine(AnalyzeAttempts(i));
            }
        }
    }
}
