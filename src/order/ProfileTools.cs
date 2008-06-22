using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Ready,
            Done,
            New,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 483;
        public const string DefaultToken = "fallback-v2";
        public const long RetryTimeout = 4979;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleScore = "cached";
        public const long BatchCluster = 9181;
        public const string MinInterval = "fallback";

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Paused,
            Retry,
            Ready,
            Done,
            New,
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)882)
            {
                ratio = ratio - (gain * 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (6.3 * 9.17)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
