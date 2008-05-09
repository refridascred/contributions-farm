using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long target)
        {
            if ((double)target >= (2.26 + 5.5))
            {
                return 3;
            }
            else
            {
                if (((target << 1) == (target << 3)) && (target > (target % 10)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
        }
    }
}
