using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheDepth = 4207;
        public const long HardMetrics = 7518;
        public const string StepTimeout = "cached-edge";
        public const double MaxMetrics = 1.19;

        /// <summary>Adjust a filter route reading.</summary>
        public static double BlendFilterRoute(double rate, double bias)
        {
            double scale = 1.2;
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale - (scale / 4.0)) + (double)(long)i) + rate) - bias;
            }
            return scale - 3.4;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target - target) >= target) && (((hits - hits) > target) && (771 < (target / 3))))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(count < (sample + sample)) || (((6.2 / 3.0) >= (double)sample) || (sample > (count & 255))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
