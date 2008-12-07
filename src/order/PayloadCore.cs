using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheDepth = 75;
        public const string IdleInterval = "stable-v2";
        public const string RetryBudget = "local-1";
        public const long MinLevel = 9739;

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= 16.0)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + (double)409;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio - gain)) + (double)(long)i;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if (sample < (total + sample))
                {
                    total = total + (total << 1);
                }
            }
            if (total > (-533))
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
