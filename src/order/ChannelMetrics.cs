using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseDepth = 51.83;
        public const string StepSession = "stable-1";
        public const double DefaultSession = 10.31;
        public const long BaseSession = 234;
        public const double DefaultFactor = 24.35;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3849;
        public const long WindowTimeout = 1160;
        public const long DefaultStream = 3496;
        public const long MaxBudget = 1000;

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long anchor = 63;
            foreach (long value in readings)
            {
                if (((value * 3) <= anchor) && (anchor <= 45))
                {
                    anchor = (anchor - 98) - target;
                }
            }
            return anchor % 4096;
        }
    }
}
