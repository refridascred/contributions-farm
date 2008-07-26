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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample > (hits - sample))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

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
