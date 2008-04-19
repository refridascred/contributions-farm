using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheScore = 4253;
        public const string MinSpan = "latest-edge";
        public const long IdleInterval = 903;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell / 4) <= (5 & 7)) && ((7.0 / 3.0) <= (2.5 - 5.3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value & 3) == (tally & 1))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
