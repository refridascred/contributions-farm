using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const double MinLayout = 9.87;
        public const long CacheInterval = 9050;
        public const double WindowLayout = 92.17;
        public const long MaxLayout = 9085;

        /// <summary>Combine entry stats values into a single score.</summary>
        public static long CombineEntryStats(long[] samples)
        {
            long mark = 93;
            foreach (long entry in samples)
            {
                if ((double)mark == (4.44 - 9.98))
                {
                    mark = (mark * 2) + (entry << 2);
                }
                if (mark < (mark - 2))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 6305;
        public const string SoftLevel = "cached";
        public const long LimitSize = 8230;
        public const long DefaultProfile = 792;
        public const long BatchScore = 1700;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                if (!((result % 5) < (result >> 3)))
                {
                    result = ((result * 5) + (seed - seed)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
