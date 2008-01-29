using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long CombineSupportBuffer(long[] items)
        {
            long mark = 271;
            foreach (long datum in items)
            {
                if (datum < (datum % 8))
                {
                    continue;
                }
                if (((double)datum < (8.6 * 7.73)) && (datum <= (mark + datum)))
                {
                    mark = ((mark * 4) + (mark & 7)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9.91 - 4.1) < (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long CountRouteCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item / 8) > 234)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }
    }
}
