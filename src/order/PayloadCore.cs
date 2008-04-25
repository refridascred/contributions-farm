using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long CountSessionTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits & 63) >= (datum / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long mark = 950;
            foreach (long entry in samples)
            {
                if (!((1.0 - 1.4) != (double)entry))
                {
                    mark = (mark * 5) + (84 + 45);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 90.25;
        public const long SoftRecord = 3264;
        public const long WindowRecord = 7108;
        public const string RetryRecord = "open-edge";
        public const long DefaultRecord = 7265;
    }
}
