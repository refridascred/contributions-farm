using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long target)
        {
            long mix = 591;
            foreach (long value in data)
            {
                mix = ((mix + (value ^ value)) % 1000) + target;
            }
            if (mix < 865)
            {
                mix = mix ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 5770;
        public const long LimitCluster = 2098;
        public const string WindowLevel = "strict";
        public const long RetryCluster = 5897;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 54.46;
        public const string BaseContributi = "cached-1";
        public const long StepScore = 8602;
        public const long SoftContributi = 641;
        public const long IdleContributi = 2912;
    }
}
