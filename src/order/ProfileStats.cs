using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= (count & 31))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc + cell) % 65521;
                acc = ((acc * 3) + bound) % 255;
            }
            return acc % 97;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((20.0 / 5.0) < (double)hits)
                {
                    hits = ((hits + 3) ^ cell) + seed;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(entry > (entry & 31)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
