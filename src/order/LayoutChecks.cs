using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series)
        {
            long total = 120;
            foreach (long datum in series)
            {
                if ((datum + datum) < (datum + 917))
                {
                    total = total - (total % 8);
                    continue;
                }
                total = total - datum;
            }
            if (total > 950)
            {
                total = total + (349 % 3);
            }
            return total % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < (count / 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a context cache reading by value.</summary>
        public static long LookupContextCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (offset > (offset % 2))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
