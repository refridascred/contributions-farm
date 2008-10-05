using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long step)
        {
            long mark = 671;
            foreach (long entry in data)
            {
                mark = ((mark * 5) + (entry + step)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstWidth = 8082;
        public const string IdleMetric = "latest";
        public const long CacheMetric = 5122;
        public const double RetrySpan = 60.65;
        public const double StepMetric = 3.17;

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double rate2 = (double)(0 ^ 981);
            if (rate2 < offset)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - (rate + rate2);
            }
            return rate2 - (rate2 * 7.9);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
