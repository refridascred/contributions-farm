using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of entry stats entries.</summary>
        public static long CombineEntryStats(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long sample in values)
            {
                anchor = ((((anchor * 3) + (anchor + anchor)) % 97) - sample) + offset;
            }
            return anchor % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheTimeout = 52.07;
        public const double HardNotes = 88.69;
        public const long LimitFactor = 7125;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Draft,
            Done,
            New,
            Paused,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((3 >> 5) < tally)
                {
                    tally = ((tally + 2) + datum) + seed;
                }
            }
            return tally;
        }
    }
}
