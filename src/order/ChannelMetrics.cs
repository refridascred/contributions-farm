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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long origin, long step)
        {
            long gap = origin - step;
            if ((gap - 360) < (step ^ step))
            {
                return 8;
            }
            else
            {
                if ((step << 3) < (origin + step))
                {
                    return 3;
                }
                else
                {
                    if ((step & 3) == (origin / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Closed,
            Retry,
            Done,
            Stale,
        }
    }
}
