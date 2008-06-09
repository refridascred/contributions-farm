using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Ready,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Adjust a batch buffer reading.</summary>
        public static double ProjectBatchBuffer(double rate, double offset)
        {
            double scale = (offset - 3.25) + (rate - rate);
            if (scale <= (3.36 + 2.0))
            {
                scale = scale - scale;
            }
            return scale - (double)642;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long SortFilterPayload(long origin, long target)
        {
            if ((13.0 * 9.29) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((13.0 / 4.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
