using Microsoft.Extensions.Configuration;
using SolidPrinciples.Interfaces;

namespace SolidPrinciples.Implementation
{
    public class ConfigurationReader(IConfiguration cfg) : IConfigurationReader
    {
        private const string MinValName = "Range:MinVal";
        private const string MaxValName = "Range:MaxVal";
        private const string AttemptsCountName = "AttemptsCount";

        public int MinVal { get; } = cfg.GetValue<int>(MinValName);
        public int MaxVal { get; } = cfg.GetValue<int>(MaxValName);
        public int AttemptsCount { get; } = cfg.GetValue<int>(AttemptsCountName);
    }
}
