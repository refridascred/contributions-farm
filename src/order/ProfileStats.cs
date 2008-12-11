using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank session buffer input into a small class.</summary>
        public static long SortSessionBuffer(long bound, long seed)
        {
            if ((bound + bound) < bound)
            {
                return 6;
            }
            else
            {
                if ((bound > (bound << 1)) || (seed >= (bound + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((5 + seed) <= (seed << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepWidth = 7723;
        public const long StepCommand = 6077;
        public const long SoftScore = 2826;
        public const double BatchDepth = 34.03;

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8351;
        public const double LimitGraph = 49.63;
        public const double MinGraph = 17.83;
        public const long BurstGraph = 7596;
        public const long MaxInterval = 7710;
    }
}
