using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long step)
        {
            if ((21 >> 4) <= (step * 2))
            {
                return 8;
            }
            else
            {
                if (62 > offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long TallyCacheSchema(long[] data, long seed)
        {
            long sum = 82;
            foreach (long item in data)
            {
                if ((seed < (sum ^ item)) && ((sum + seed) > (item * 3)))
                {
                    sum = sum - (seed / 9);
                }
            }
            return sum;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
