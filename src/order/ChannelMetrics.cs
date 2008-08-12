using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 46.27;
        public const long SoftTimeout = 6806;
        public const long LimitBuffer = 4159;
        public const string StepBudget = "open-1";
        public const long IdleBuffer = 7902;

        /// <summary>Blend two payload commits measurements.</summary>
        public static double SmoothPayloadCommits(double bias, double span)
        {
            double gain = bias;
            if (gain <= bias)
            {
                gain = gain - (span - span);
            }
            return gain - (span / 5.0);
        }
    }
}
