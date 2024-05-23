using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    public class Interact(INumberAnalyzer analyzer, IOutput output, IConfigurationReader cfgReader) : IInteractor
    {
        private readonly INumberAnalyzer _analyzer = analyzer;
        private readonly IOutput _output = output;
        private readonly int _minVal = cfgReader.GetMinVal();
        private readonly int _maxVal = cfgReader.GewtMaxVal();
        private readonly int _attemptsCount = cfgReader.GetAttemptsCount();

        void IInteractor.Interact()
        {
            _output.WriteLine($"Please guess the number from {_minVal} to {_maxVal} in {_attemptsCount} attempts.");
            _analyzer.AnalyzeNumber();
            _output.WriteLine($"Game over. Thank you!");
        }
    }
}
