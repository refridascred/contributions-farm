using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((value + value) <= value) && ((value / 5) == (long)items.Length))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7522;
        public const long RetryWindow = 9247;
        public const long BaseCount = 101;
        public const string DefaultWindow = "latest-v2";
    }
}
