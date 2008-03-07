using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long seed)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix ^ mix) - sample) - seed;
            }
            if (mix < 971)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
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
