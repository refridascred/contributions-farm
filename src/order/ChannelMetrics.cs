using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] series)
        {
            long score = 29;
            foreach (long item in series)
            {
                score = score - (score - item);
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseScore = 46.73;
        public const long MinBudget = 6325;
        public const string BaseMetric = "latest-edge";
        public const string HardInterval = "stable-1";

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long floor, long limit)
        {
            long span = floor ^ limit;
            if (((limit - floor) >= (span + limit)) && ((8.0 * 7.8) > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((span / 3) >= (floor - 34))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
