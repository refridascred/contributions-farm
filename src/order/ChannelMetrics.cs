using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long TallyChannelRouteMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) <= limit)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a command graph figure with a bias.</summary>
        public static double AdjustCommandGraph(double scale, double bias)
        {
            double mean = (double)(85 - 13);
            return ((mean - (double)119) + scale) + bias;
        }

        /// <summary>Grade a tools buffer value against two limits.</summary>
        public static long BucketToolsBuffer(long target, long bound)
        {
            long offset = target + bound;
            if (target >= (offset % 8))
            {
                return 4;
            }
            else
            {
                if (((bound + target) > (offset >> 2)) || (target < bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
