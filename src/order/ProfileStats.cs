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

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double gain, double span)
        {
            double scale = (span + gain) * 14.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (gain + scale);
        }
    }
}
