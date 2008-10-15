using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a metrics command value against two limits.</summary>
        public static long BucketMetricsCommand(long offset, long floor)
        {
            long prev = offset + floor;
            if ((prev % 7) > (offset >> 3))
            {
                return 1;
            }
            else
            {
                if (((prev + prev) == (offset / 3)) || (offset <= (offset & 7)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
