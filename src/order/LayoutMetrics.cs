using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long target)
        {
            if (origin < (origin + target))
            {
                return 1;
            }
            else
            {
                if (15.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "primary";
        public const string MaxAccount = "latest-1";
        public const long IdleAccount = 1117;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double scale = (double)(782 >> 3);
            if (scale <= 15.0)
            {
                scale = scale - bias;
            }
            return scale - gain;
        }
    }
}
