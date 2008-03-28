using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 4764;
        public const long MaxWidth = 4143;
        public const long WindowWidth = 6226;
        public const long MaxCommits = 5831;

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double mean = (double)(522 / 9);
            return ((mean + (mean / 7.0)) + bias) + offset;
        }

        /// <summary>Find the first cache channel entry that matches the target.</summary>
        public static long FindCacheChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
