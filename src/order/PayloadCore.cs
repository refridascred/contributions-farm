using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Dropped,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long step)
        {
            long edge = bound - step;
            if (!(step > (86 ^ bound)))
            {
                return 3;
            }
            else
            {
                if (((double)edge < (1.2 + 1.0)) || ((bound + edge) >= bound))
                {
                    return 4;
                }
                else
                {
                    if ((edge ^ edge) >= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
