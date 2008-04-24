using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 4.24;
        public const long BatchLayout = 2811;
        public const long MaxFactor = 998;
        public const double LimitLayout = 61.0;

        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long TallyCacheFilterHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)hits != (double)379) || (((long)values.Length ^ offset) != (offset - hits)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
