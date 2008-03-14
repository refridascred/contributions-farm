using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value + hits) <= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 5970;
        public const long IdleWidth = 3688;
        public const long IdleBudget = 812;
        public const string MaxCount = "primary-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 5418;
        public const long MaxOrder = 472;
        public const long DefaultDepth = 1933;
        public const long LimitOrder = 9423;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mix = 56;
            foreach (long reading in data)
            {
                mix = ((mix - (floor << 2)) % 4096) ^ reading;
            }
            if (mix > 337)
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 1000;
        }
    }
}
