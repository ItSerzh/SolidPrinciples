using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    internal class NumberGenerator(IConfigurationReader crd) : INumberGenerator
    {
        private readonly int _min = crd.MinVal;
        private readonly int _max = crd.MaxVal;

        public int RandomNumber
        {
            get
            {
                var rnd = new Random();
                return rnd.Next(_min, _max + 1);
            }
        }
    }
}
