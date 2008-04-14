using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long RollContributiAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Idle,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 9) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
