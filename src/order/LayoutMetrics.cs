using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long carry = 96;
            foreach (long item in items)
            {
                if ((item ^ item) > (item - item))
                {
                    carry = ((carry * 5) + item) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Failed,
            Draft,
        }
    }
}
