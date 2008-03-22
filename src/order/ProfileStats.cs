using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long step)
        {
            if (origin >= (origin - step))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < (origin - 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
