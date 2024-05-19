using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    internal class NumberGenerator
    {
        private readonly int _min;
        private readonly int _max;

        public NumberGenerator(ConfigurationReader crd)
        {
            _min = crd.GetMinVal();
            _max = crd.GetMaxVal();
        }

        public int GetRandomNumber()
        {
            var rnd = new Random();
            return rnd.Next(_min, _max+1);
        }
    }
}
