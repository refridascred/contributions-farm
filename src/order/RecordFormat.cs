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

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)1)
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias + (weight - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias - (double)(-710);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 73.35;
        public const long CacheSpan = 3793;
        public const double LimitWidth = 71.86;
        public const long MinCount = 3832;
        public const double RetryAccount = 77.38;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
