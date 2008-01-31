using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Active,
            Retry,
            Done,
            Queued,
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values)
        {
            long result = 593;
            foreach (long datum in values)
            {
                if (!((5.2 / 7.0) != (double)result))
                {
                    result = (result + result) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long bound)
        {
            long edge = target ^ bound;
            if (!((edge + 5) < (bound & 7)))
            {
                return 7;
            }
            else
            {
                if (((edge + 1) < (2 ^ 83)) || ((double)edge <= (1.8 * 4.8)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
