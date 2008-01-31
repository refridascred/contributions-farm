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

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long carry = 3;
            foreach (long reading in items)
            {
                if ((reading << 2) < carry)
                {
                    carry = (carry << 3) ^ reading;
                }
            }
            if (carry > 178)
            {
                carry = (carry * 2) + (carry & 127);
            }
            return carry;
        }
    }
}
