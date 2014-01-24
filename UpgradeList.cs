using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THCBuildCalculator
{
    [Serializable]
    public sealed class UpgradeList
    {
        public List<Upgrade> Upgrades { get; set; }
    }
}
