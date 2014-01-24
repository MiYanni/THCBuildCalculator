using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THCBuildCalculator
{
    [Serializable]
    public sealed class Upgrade
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsTeamLocked { get; set; }

        public int MaxLevel { get; set; }

        public int InitialCost { get; set; }

        public int IncrementalCost { get; set; }

        public List<Effect> Effects { get; set; }
    }
}
