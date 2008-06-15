using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardSpan = "primary";
        public const long WindowRoute = 5539;
        public const double RetryFactor = 84.62;
        public const long DefaultRatio = 9566;
        public const long SoftLevel = 7937;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long origin)
        {
            long total = 59;
            foreach (long item in items)
            {
                if ((double)origin == (5.05 * 8.69))
                {
                    total = (((total * 2) + (723 / 6)) % 1000) ^ item;
                }
            }
            if (total > 982)
            {
                total = total - (total * 5);
            }
            return total % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long TallyMetricAlreadyHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((8.9 / 8.0) >= (double)floor)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
