using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 75.47;
        public const long CacheRoute = 2251;
        public const double WindowFactor = 70.84;
        public const string WindowRoute = "latest";
        public const long StepRoute = 9760;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (40 * 3)) % 1000;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 60.16;
        public const long RetryCount = 1055;
        public const long RetryScore = 6419;
    }
}
