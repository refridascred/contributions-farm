using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long seed, long floor)
        {
            long prev = seed + floor;
            if ((double)floor > 7.0)
            {
                return 7;
            }
            else
            {
                if ((prev + 59) != (917 - floor))
                {
                    return 8;
                }
                else
                {
                    if (((0.15 / 8.0) >= (double)seed) || ((double)floor == (7.8 + 20.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up layout profile samples.</summary>
        public static long OverlapLayoutProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 1879;
        public const string DefaultRatio = "standard-v2";
        public const string HardStream = "primary-1";
    }
}
