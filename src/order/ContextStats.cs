using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "alpha-edge";
        public const long HardSupport = 657;
        public const long MaxCount = 776;
        public const long BurstSupport = 812;

        /// <summary>Measure how many contributi metric samples are out of range.</summary>
        public static long AuditContributiMetricOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((limit & 31) <= (limit ^ matches)) || (((9.0 / 3.0) == (double)limit) && ((463 << 3) <= (matches << 3))))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

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
