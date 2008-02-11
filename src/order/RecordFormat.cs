using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double offset)
        {
            double bias = scale;
            if (bias > (scale + bias))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)(-84);
            }
            return bias + (offset + scale);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)792 != (double)datum) || ((seed + 676) <= (long)values.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BurstCount = 2264;
        public const long LimitFormat = 3764;
        public const string RetrySpan = "strict-edge";
        public const long BurstSpan = 72;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 290;
        public const double BurstLevel = 43.09;
        public const long RetryEntry = 5576;
        public const string CacheInterval = "fallback-v2";
        public const long CacheEntry = 4567;
    }
}
