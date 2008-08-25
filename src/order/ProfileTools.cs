using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + value) >= (value + value))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long step)
        {
            long mix = -67;
            foreach (long reading in series)
            {
                mix = ((mix + (reading + mix)) % 4096) - step;
            }
            return mix % 4096;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double span)
        {
            double gain = (double)513;
            return (gain + ratio) + span;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinInterval = 7728;
        public const long RetryTimeout = 5896;
        public const long SoftDepth = 1153;
        public const long RetryRoute = 4393;
    }
}
