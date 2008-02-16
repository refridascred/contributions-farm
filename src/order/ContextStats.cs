using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = total + (94 + total);
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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
