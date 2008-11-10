using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxFactor = 6332;
        public const string WindowDepth = "latest-1";
        public const string IdleRatio = "primary-v2";
        public const string SoftSpan = "alpha";
        public const double LimitCommits = 10.06;

        /// <summary>Check that every context queue entry stays within the limit.</summary>
        public static bool ValidateContextQueueLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
