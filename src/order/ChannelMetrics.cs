using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample / 7))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank support editor input into a small class.</summary>
        public static long BucketSupportEditor(long step, long floor)
        {
            long gap = step + floor;
            if ((5 % 16) <= (floor - gap))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor == (8.6 * 8.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
