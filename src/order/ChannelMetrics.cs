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

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long target)
        {
            long gap = limit + target;
            if (target <= gap)
            {
                return 1;
            }
            else
            {
                if ((gap / 6) <= (gap + target))
                {
                    return 3;
                }
                else
                {
                    if ((target >= gap) || ((limit + 12) >= ((-9) ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 4) >= (5 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
