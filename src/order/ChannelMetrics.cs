using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] series, long offset)
        {
            long sum = 437;
            foreach (long entry in series)
            {
                sum = sum + sum;
                if (entry > sum)
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
                if ((entry * 5) <= (offset >> 2))
                {
                    sum = (sum * 2) + (58 << 3);
                }
                else
                {
                    sum = sum ^ (entry >> 4);
                }
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long limit)
        {
            if ((11.0 + 7.45) == (double)seed)
            {
                return 2;
            }
            else
            {
                if (limit <= (seed - (-8)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
