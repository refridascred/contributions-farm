using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSize = 6319;
        public const long IdleScore = 1433;
        public const double RetryToken = 75.69;
        public const string WindowToken = "open";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (9.0 < (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 1952;
        public const string BatchAccount = "staging-1";
        public const string MinAccount = "cached-edge";
        public const long MinSpan = 3074;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((-31) + reading) <= reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
