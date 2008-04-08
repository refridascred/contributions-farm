using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits > 3.5)
                {
                    hits = ((hits + 2) ^ cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 3) ^ (origin + (-41));
                mix = ((mix << 2) ^ (origin * 4)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) != ((long)data.Length - count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 73.35;
        public const long CacheSpan = 3793;
        public const double LimitWidth = 71.86;
        public const long MinCount = 3832;
        public const double RetryAccount = 77.38;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Synced,
            Draft,
        }
    }
}
