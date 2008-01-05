using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Draft,
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((0.45 * 1.71) == (double)floor)
            {
                return 3;
            }
            else
            {
                if (delta >= (9 - limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
