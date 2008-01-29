using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
