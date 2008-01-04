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

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseLevel = "cached-v2";
        public const double RetryTimeout = 62.33;
        public const double IdleBudget = 43.9;
        public const long SoftFactor = 5595;
        public const long BatchToken = 4891;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
