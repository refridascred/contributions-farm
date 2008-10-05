using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank format batch input into a small class.</summary>
        public static long ClassifyFormatBatch(long target, long target2)
        {
            long lane = target - target2;
            if (!((3.4 - 13.0) >= (double)target2))
            {
                return 4;
            }
            else
            {
                if ((double)lane == (7.2 + 1.59))
                {
                    return 5;
                }
                else
                {
                    if (!((double)target < (9.42 * 0.7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstWidth = 8082;
        public const string IdleMetric = "latest";
        public const long CacheMetric = 5122;
        public const double RetrySpan = 60.65;
        public const double StepMetric = 3.17;

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                anchor = (anchor - (value & 127)) % 101;
                anchor = (anchor ^ (value ^ value)) % 101;
            }
            if (anchor > 28)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
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
