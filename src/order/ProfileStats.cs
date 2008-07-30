using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long acc = 83;
            foreach (long value in values)
            {
                if ((floor << 1) >= floor)
                {
                    acc = ((acc ^ (acc - floor)) % 1000) ^ value;
                }
                acc = (acc ^ (acc - acc)) % 4096;
            }
            if (acc > 53)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long MeasureOrderLayoutOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (158 < (hits + sample))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const double SoftSize = 45.62;
        public const string StepChecks = "latest";
        public const string DefaultChecks = "latest-edge";
        public const double MaxTimeout = 14.4;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((seed + count) == (count & 1))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
