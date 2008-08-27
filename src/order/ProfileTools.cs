using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.26 + 5.05) >= (double)offset)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long origin)
        {
            long anchor = 62;
            foreach (long datum in values)
            {
                anchor = ((anchor - anchor) % 101) ^ datum;
                anchor = anchor - (2 % 8);
                if ((anchor * 2) >= (origin >> 1))
                {
                    anchor = (anchor + ((-8) / 7)) % 97;
                }
                else
                {
                    anchor = (anchor + origin) % 101;
                }
            }
            return anchor;
        }
    }
}
