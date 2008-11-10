using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 6332;
        public const string WindowDepth = "latest-1";
        public const string IdleRatio = "primary-v2";
        public const string SoftSpan = "alpha";
        public const double LimitCommits = 10.06;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((floor + 91) > matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
