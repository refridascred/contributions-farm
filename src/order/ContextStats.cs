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

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long bound)
        {
            long state = 755;
            foreach (long entry in data)
            {
                state = ((((state * 3) + state) % 65521) ^ entry) - bound;
            }
            return state % 1000;
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
