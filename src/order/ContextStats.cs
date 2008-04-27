using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Stale,
            Draft,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = ((carry * 4) + (-182)) % 65521;
                if (!((carry & 31) != (item - carry)))
                {
                    carry = (carry ^ (item ^ 8)) % 255;
                }
                else
                {
                    carry = carry - (item + carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((offset * 2) >= (offset ^ count))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Queued,
            Active,
        }
    }
}
