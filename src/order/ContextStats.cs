using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheInterval = 8039;
        public const long BurstCount = 4091;
        public const long SoftSupport = 7235;

        /// <summary>Grade a window profile value against two limits.</summary>
        public static long ClassifyWindowProfile(long floor, long seed)
        {
            long lane = floor - seed;
            if ((floor + floor) == (lane + 66))
            {
                return 3;
            }
            else
            {
                if (((double)seed != (1.7 - 4.0)) && (seed < floor))
                {
                    return 7;
                }
                else
                {
                    if ((7 + lane) == (lane + lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(8.5 > (double)item))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double bias2 = (double)(9 - 75);
            if (bias2 > (double)2)
            {
                bias2 = (bias2 + (double)25) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (3.9 - offset)) + (double)(long)i;
            }
            return bias2 + (offset - bias2);
        }
    }
}
