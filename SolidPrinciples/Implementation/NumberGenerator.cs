using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    internal class NumberGenerator(IConfigurationReader crd) : INumberGenerator
    {
        private readonly int _min = crd.GetMinVal();
        private readonly int _max = crd.GewtMaxVal();

        public int GetRandomInt()
        {
            var rnd = new Random();
            return rnd.Next(_min, _max + 1);
        }
    }
}
