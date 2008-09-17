using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double mean = 0.6;
            if (mean < mean)
            {
                mean = (mean - (19.0 / 4.0)) - bias;
            }
            return mean - (mean - floor);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 9615;
        public const long BaseBuffer = 5240;
        public const long WindowScore = 9369;
        public const long WindowTimeout = 8003;

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                long matches = (sum + target) / 5;
                if (((long)i - matches) <= ((long)i - target))
                {
                    sum = (sum << 2) ^ (matches + 354);
                    sum = sum - 45;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
