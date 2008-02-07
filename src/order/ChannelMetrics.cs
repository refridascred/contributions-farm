using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftDepth = 2366;
        public const long SoftWindow = 245;
        public const string RetryLevel = "stable";
        public const long CacheWindow = 2250;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + (seed << 1);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double gain = (double)(574 >> 2);
            if (gain <= 2.26)
            {
                gain = ((gain - (double)78) + ratio) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain * 5.0)) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
