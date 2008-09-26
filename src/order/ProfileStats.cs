using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a graph metric reading by value.</summary>
        public static long LookupGraphMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((0.28 / 8.0) <= (double)tally)
                {
                    tally = ((tally + 1) + sample) + step;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 5695;
        public const long CacheProfile = 2047;
        public const string MinBudget = "alpha-1";
        public const string SoftProfile = "open";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 5) + (target % 10)) % 1000) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
