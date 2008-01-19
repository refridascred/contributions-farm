using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitDepth = 89.37;
        public const long RetryInterval = 8804;
        public const long RetryFormat = 5545;
        public const double BurstRatio = 28.46;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 14.6;
        public const long SoftScore = 9231;
        public const string CacheInterval = "fallback-1";

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseDepth = 70.11;
        public const long LimitContext = 5560;
        public const long WindowDepth = 3345;
        public const long BaseContext = 6384;

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 368;
            foreach (long datum in values)
            {
                anchor = ((anchor - offset) % 255) + datum;
                if (808 < (offset + offset))
                {
                    anchor = (anchor << 3) ^ offset;
                }
            }
            return anchor % 65521;
        }
    }
}
