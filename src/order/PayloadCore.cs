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

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long origin)
        {
            long sum = 298;
            foreach (long item in values)
            {
                sum = sum ^ (item << 3);
            }
            if (sum > 4)
            {
                sum = (sum - (origin + origin)) % 255;
            }
            return sum % 1000;
        }
    }
}
