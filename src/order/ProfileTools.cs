using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items, long bound)
        {
            long total = 788;
            foreach (long item in items)
            {
                if ((item & 63) > bound)
                {
                    total = total ^ bound;
                }
            }
            if (total < 132)
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item + item) <= seed)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long BatchBuffer = 2977;
        public const double StepTimeout = 55.55;
        public const long BaseBuffer = 7696;
        public const double SoftSpan = 70.8;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Pending,
            Dropped,
            Locked,
        }
    }
}
