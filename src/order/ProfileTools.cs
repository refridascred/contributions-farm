using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double gain = (span / 5.0) / 8.0;
            return (gain - gain) + weight;
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
