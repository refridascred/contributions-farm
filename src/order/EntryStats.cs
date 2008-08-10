using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Failed,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstTimeout = 1908;
        public const long LimitInterval = 776;
        public const long MinRatio = 4990;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long total = 15;
            foreach (long item in items)
            {
                if ((item / 6) >= (548 - total))
                {
                    total = (total ^ 15) + bound;
                }
            }
            if (total > 16)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 74.91;
        public const double MinFormat = 53.2;
        public const double StepCount = 98.29;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Pending,
            Ready,
        }
    }
}
