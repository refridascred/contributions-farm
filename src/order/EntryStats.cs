using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)origin == (4.7 * 6.8)) && (origin < (origin >> 1)))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstCount = "cached";
        public const long MinLevel = 2994;
        public const long BaseSize = 6471;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Failed,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
