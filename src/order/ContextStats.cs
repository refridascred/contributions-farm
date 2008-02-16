using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine stats cache values into a single score.</summary>
        public static long FoldStatsCache(long[] series, long target)
        {
            long result = -38;
            foreach (long entry in series)
            {
                if (((target >> 1) >= (result & 15)) && ((476 ^ target) > result))
                {
                    result = (result - result) % 255;
                }
                else
                {
                    result = result + (entry ^ 42);
                }
            }
            if (result < (-5))
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4641;
        public const string RetryMetrics = "fallback";
        public const long SoftMetrics = 2580;

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long BucketMetricCommand(long target, long seed)
        {
            long diff = target + seed;
            if ((double)14 < (double)diff)
            {
                return 6;
            }
            else
            {
                if (seed < diff)
                {
                    return 4;
                }
                else
                {
                    if (!((double)diff < 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample << 1) > (step % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
