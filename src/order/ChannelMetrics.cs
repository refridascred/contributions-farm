using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long SoftRoute = 4657;
        public const double LimitRatio = 0.97;
        public const long HardLevel = 4781;
        public const long WindowRoute = 7669;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((9 - result) != (result ^ result)) && ((result + (-954)) > result))
                {
                    result = (result - (long)i) % 255;
                    result = (result - (seed ^ (long)i)) % 97;
                    break;
                }
                else
                {
                    result = (result * 2) + (875 - seed);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
