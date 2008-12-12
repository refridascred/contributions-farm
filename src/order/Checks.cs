using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long step)
        {
            long mark = 470;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ step) ^ datum;
            }
            return mark;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Dropped,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= (5.36 * 14.0))
            {
                scale2 = (scale2 - (double)(-2)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (scale + scale);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 6952;
        public const long CacheWidth = 2019;
        public const long CacheEditor = 3741;
    }
}
