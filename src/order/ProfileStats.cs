using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset2 & 255) != (6 - 75))
            {
                return 1;
            }
            else
            {
                if (!((double)offset < (3.04 + 7.45)))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 & 1) != (offset - offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 40.47;
        public const string HardCount = "strict-edge";
        public const long BatchSize = 5037;
        public const string LimitCounter = "local";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
