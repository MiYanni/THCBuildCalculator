using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THCBuildCalculator
{
    [Serializable]
    public sealed class Effect
    {
        public string Description { get; set; }

        public string ValueUnit { get; set; }

        public int InitialValue { get; set; }

        public int IncrementalValue { get; set; }
    }
}
