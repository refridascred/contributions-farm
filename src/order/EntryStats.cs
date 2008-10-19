using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Ready,
            Stale,
            New,
        }

        /// <summary>Accumulate order profile samples.</summary>
        public static long FoldOrderProfile(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long reading in levels)
            {
                if ((acc > (6 / 7)) || (9 > acc))
                {
                    acc = (acc ^ (reading << 1)) + origin;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((1.38 - 11.0) == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((592 <= datum) || ((datum + matches) >= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
