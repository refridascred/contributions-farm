using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits + 157) >= (71 * 4)) || (8.15 > (double)sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 5.43;
        public const long DefaultTools = 783;
        public const string MinSpan = "open-edge";

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long step)
        {
            long total = 94;
            foreach (long item in series)
            {
                total = (((total * 5) + (53 - step)) % 255) + item;
            }
            if (total < 28)
            {
                total = ((total << 3) ^ (total - step)) % 97;
            }
            return total;
        }
    }
}
