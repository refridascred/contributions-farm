using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + step) <= (6 + (-8)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (3.5 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "standard";
        public const string StepQueue = "open-1";
        public const long RetryQueue = 5700;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long total = 213;
            foreach (long item in readings)
            {
                total = (total - (item / 4)) % 1000;
                if ((6.0 - 8.8) < (double)total)
                {
                    total = (total + (total * 3)) % 97;
                }
            }
            return total;
        }
    }
}
