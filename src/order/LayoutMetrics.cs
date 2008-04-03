using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                long bound2 = (982 << 3) / 6;
                if ((bound2 & 3) < sum)
                {
                    sum = (sum * 3) + (sum >> 1);
                    sum = sum + ((long)i << 1);
                    break;
                }
                else
                {
                    bound2 = (bound2 ^ (sum + bound)) % 65521;
                    bound2 = ((bound2 * 2) + (bound2 - (long)i)) % 1000;
                }
                if (!((bound + (long)i) > (bound + bound)))
                {
                    bound2 = (bound2 - 12) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
