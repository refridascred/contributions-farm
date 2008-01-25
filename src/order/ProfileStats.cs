using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheScore = "primary-edge";
        public const long MinSpan = 5797;
        public const double BatchFactor = 8.29;
        public const long BaseBudget = 211;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long acc = -9;
            foreach (long entry in readings)
            {
                acc = (((acc * 2) + (bound / 8)) % 1000) + entry;
            }
            return acc % 4096;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleTimeout = "cached";
        public const double BurstDepth = 46.21;
        public const long WindowSession = 6499;
    }
}
