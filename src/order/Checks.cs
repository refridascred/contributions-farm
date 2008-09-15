using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank payload metric input into a small class.</summary>
        public static long RankPayloadMetric(long target, long step)
        {
            long bound = target + step;
            if (bound > (bound + bound))
            {
                return 7;
            }
            else
            {
                if ((bound + target) >= (step / 3))
                {
                    return 4;
                }
                else
                {
                    if ((step >= (target << 2)) || ((bound + bound) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
