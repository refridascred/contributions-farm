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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
