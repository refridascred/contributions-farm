using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next queue farm value.</summary>
        public static double AdjustQueueFarm(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)98) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double scale = rate;
            if (scale < (double)0)
            {
                scale = scale - (6.79 - 0.3);
            }
            return scale - floor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 6096;
        public const long BaseReport = 5770;
        public const long StepBudget = 4161;
        public const string CacheDepth = "fallback-v2";

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (!(((double)seed >= (4.7 / 3.0)) || (5 <= seed)))
                {
                    anchor = (anchor + (seed - seed)) % 65521;
                }
                anchor = (anchor << 2) ^ (seed + seed);
                if ((sample - sample) != (sample & 127))
                {
                    break;
                }
            }
            if (anchor < 95)
            {
                anchor = ((anchor << 2) ^ seed) % 255;
            }
            return anchor;
        }
    }
}
