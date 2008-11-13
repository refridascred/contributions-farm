using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a token order reading by value.</summary>
        public static long SeekTokenOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter entry pair into a bucket.</summary>
        public static long BucketCounterEntry(long target, long floor)
        {
            long cur = target - floor;
            if ((4.0 - 7.0) > (double)cur)
            {
                return 6;
            }
            else
            {
                if ((floor - cur) <= (target / 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
