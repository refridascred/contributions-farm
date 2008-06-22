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

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= ratio)
            {
                bias = (bias + ratio) + offset;
            }
            else
            {
                bias = bias + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + 3.77;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Dropped,
            Idle,
            Queued,
        }
    }
}
