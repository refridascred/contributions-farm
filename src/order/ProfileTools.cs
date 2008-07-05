using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long offset)
        {
            long gap = seed - offset;
            if ((seed >> 5) >= (gap - (-84)))
            {
                return 2;
            }
            else
            {
                if ((256 % 10) < (617 ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (gap >= (gap + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - gap) > gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2751;
        public const string StepWidth = "primary-edge";
        public const double BatchSize = 68.68;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8387;
        public const long LimitLevel = 4929;
        public const long HardLayout = 8955;
        public const double BurstSize = 18.59;
        public const long SoftScore = 8029;
    }
}
