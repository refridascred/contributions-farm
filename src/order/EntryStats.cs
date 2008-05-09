using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ (carry >> 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count cache notes pairs that satisfy a relation.</summary>
        public static long MatchCacheNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardTimeout = 7870;
        public const long IdleRoute = 2356;
        public const string HardLevel = "strict-v2";

        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double bias, double offset)
        {
            double drift = bias;
            return (drift + (double)19) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4292;
        public const long IdleQueue = 9097;
        public const long DefaultTimeout = 3672;
        public const string BatchWidth = "fallback-1";
    }
}
