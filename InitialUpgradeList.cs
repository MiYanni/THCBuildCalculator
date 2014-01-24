using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace THCBuildCalculator
{
    internal static class InitialUpgradeList
    {
        public static UpgradeList Create()
        {
            return new UpgradeList
            {
                Upgrades = new List<Upgrade>
                {
                    new Upgrade 
                    { 
                        Name = "Adrenaline", 
                        Description = "Increases your movement speed upon receiving enemy damage.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 6,
                        InitialCost = 5,
                        IncrementalCost = 10,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Speed reduced by 15% per level",
                                InitialValue = 0,
                                IncrementalValue = 15,
                                ValueUnit = "% movement speed increase when damaged."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "BouncyBullets", 
                        Description = "Your bullet damage to an enemy pushes them back (knockback).",
                        IsEnabled = false,
                        IsTeamLocked = false,
                        MaxLevel = 5,
                        InitialCost = 10,
                        IncrementalCost = 20,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Bounce Power 100% multiplied by level (2 feet = 100%)",
                                InitialValue = 0,
                                IncrementalValue = 2,
                                ValueUnit = " feet increased knockback."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "Damage+", 
                        Description = "Increases your attack damage to enemies.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 5,
                        InitialCost = 5,
                        IncrementalCost = 12,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Percentage capped at 10% per level (increase on damage done)",
                                InitialValue = 0,
                                IncrementalValue = 10,
                                ValueUnit = "% attack damage."
                            }
                        }
                    },
                }
            };
        }
    }
}
