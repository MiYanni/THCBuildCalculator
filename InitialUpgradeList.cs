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
                    new Upgrade 
                    { 
                        Name = "FireNade", 
                        Description = "Your HE grenade damage lights enemies on fire.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 10,
                        InitialCost = 10,
                        IncrementalCost = 10,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Burns for 1 second(s) per level",
                                InitialValue = 0,
                                IncrementalValue = 1,
                                ValueUnit = " second to burn duration."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "FirePistol", 
                        Description = "Your pistol bullet damage lights enemies on fire.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 10,
                        InitialCost = 5,
                        IncrementalCost = 12,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Burns for 1 second(s) per level",
                                InitialValue = 0,
                                IncrementalValue = 1,
                                ValueUnit = " second to burn duration."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "FrostNade", 
                        Description = "Your HE grenade damage freezes enemies.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 10,
                        InitialCost = 10,
                        IncrementalCost = 10,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Frozen targets do 50% less damage",
                                InitialValue = 50,
                                IncrementalValue = 0,
                                ValueUnit = "% damage reduction."
                            },
                            new Effect
                            {
                                Description = "Frozen targets base movement speed is slowed by 60%",
                                InitialValue = 60,
                                IncrementalValue = 0,
                                ValueUnit = "% movement speed reduction."
                            },
                            new Effect
                            {
                                Description = "Freezes targets for 2 seconds + .5 seconds per level",
                                InitialValue = 2,
                                IncrementalValue = .5,
                                ValueUnit = " seconds to freeze duration."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "FrostPistol", 
                        Description = "Your pistol bullet damage freezes enemies.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 10,
                        InitialCost = 10,
                        IncrementalCost = 15,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Frozen targets do 50% less damage",
                                InitialValue = 50,
                                IncrementalValue = 0,
                                ValueUnit = "% damage reduction."
                            },
                            new Effect
                            {
                                Description = "Frozen targets base movement speed is slowed by 60%",
                                InitialValue = 60,
                                IncrementalValue = 0,
                                ValueUnit = "% movement speed reduction."
                            },
                            new Effect
                            {
                                Description = "Freezes targets for 2 seconds + .5 seconds per level",
                                InitialValue = 2,
                                IncrementalValue = .5,
                                ValueUnit = " seconds to freeze duration."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "Gravity-", 
                        Description = "Reduces your gravity.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 5,
                        InitialCost = 5,
                        IncrementalCost = 15,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Reduces gravity on player by 5% per level",
                                InitialValue = 0,
                                IncrementalValue = 5,
                                ValueUnit = "% gravity of the server's gravity value."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "Health+", 
                        Description = "Increases your max health.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 6,
                        InitialCost = 5,
                        IncrementalCost = 10,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "25 Additional HP per level",
                                InitialValue = 0,
                                IncrementalValue = 25,
                                ValueUnit = " health points."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "IceStab", 
                        Description = "Your knife stab damage freezes enemies.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 10,
                        InitialCost = 10,
                        IncrementalCost = 20,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Frozen targets do 50% less damage",
                                InitialValue = 50,
                                IncrementalValue = 0,
                                ValueUnit = "% damage reduction."
                            },
                            new Effect
                            {
                                Description = "Frozen targets base movement speed is slowed by 60%",
                                InitialValue = 60,
                                IncrementalValue = 0,
                                ValueUnit = "% movement speed reduction."
                            },
                            new Effect
                            {
                                Description = "Freezes targets for 2 seconds + .5 seconds per level",
                                InitialValue = 2,
                                IncrementalValue = .5,
                                ValueUnit = " seconds to freeze duration."
                            }
                        }
                    },
                    new Upgrade 
                    { 
                        Name = "Impulse", 
                        Description = "While firing bullets, increases your movement speed.",
                        IsEnabled = true,
                        IsTeamLocked = false,
                        MaxLevel = 6,
                        InitialCost = 10,
                        IncrementalCost = 10,
                        Effects = new List<Effect>
                        {
                            new Effect
                            {
                                Description = "Player speed increased by 15% for .5 seconds after firing",
                                InitialValue = 0,
                                IncrementalValue = 15,
                                ValueUnit = "% movement speed increase."
                            }
                        }
                    },
                }
            };
        }
    }
}
