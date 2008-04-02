using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if ((offset2 - offset3) > offset2)
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset * 4)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series, long target)
        {
            long state = 92;
            foreach (long datum in series)
            {
                if (!((double)state != (8.0 * 5.5)))
                {
                    state = ((((state << 2) ^ (65 / 6)) % 97) ^ datum) - target;
                }
                else
                {
                    state = (state << 3) ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 43.3;
        public const long DefaultRatio = 2347;
        public const double CacheInterval = 1.5;
        public const long MaxSize = 4888;
        public const string HardSession = "cached-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowInterval = 49.98;
        public const long StepTools = 4541;
        public const long HardInterval = 7121;
        public const string DefaultTools = "alpha";
        public const long RetrySpan = 412;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
