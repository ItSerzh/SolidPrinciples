using Microsoft.Extensions.Configuration;
using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    public class ConfigurationReader(IConfiguration cfg) : IConfigurationReader
    {
        private const string MinValName = "Range:MinVal";
        private const string MaxValName = "Range:MaxVal";
        private const string AttemptsCountName = "AttemptsCount";

        public int GetMinVal()
        {
            return cfg.GetValue<int>(MinValName);
        }
        public int GewtMaxVal()
        {
            return cfg.GetValue<int>(MaxValName);
        }
        public int GetAttemptsCount()
        {
            return cfg.GetValue<int>(AttemptsCountName);
        }
    }
}
