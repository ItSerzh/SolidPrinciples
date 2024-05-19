using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class ConfigurationReader
    {
        private const string MinVal = "Range:MinVal";
        private const string MaxVal = "Range:MaxVal";
        private const string AttemptsCount = "AttemptsCount";
        
        private readonly int _minVal;
        private readonly int _maxVal;
        private readonly int _attemptsCount;

        public ConfigurationReader(IConfiguration cfg)
        {
            _minVal = cfg.GetValue<int>(MinVal);
            _maxVal = cfg.GetValue<int>(MaxVal);
            _attemptsCount = cfg.GetValue<int>(AttemptsCount);
        }

        public int GetMinVal() => _minVal;
        public int GetMaxVal() => _maxVal;
        public int GetAttemptsCount() => _attemptsCount; 
    }
}
