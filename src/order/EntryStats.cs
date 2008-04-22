using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry & 7) < (entry - 66))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order payload reading by value.</summary>
        public static long SeekOrderPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 31;
        public const long RetrySize = 8541;
        public const long HardSupport = 3286;
        public const string BatchFactor = "primary-1";
        public const long RetrySupport = 9831;

        /// <summary>Combine githubfarm session values into a single score.</summary>
        public static long TotalGithubfarmSession(long[] samples, long seed)
        {
            long state = 397;
            foreach (long entry in samples)
            {
                state = ((state - (4 + seed)) % 4096) - entry;
            }
            return state;
        }

        /// <summary>Look up the position of a checks buffer sample.</summary>
        public static long LocateChecksBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
