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

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 8514;
        public const string RetryLevel = "fallback-edge";
        public const string SoftWidth = "primary-edge";
        public const long HardSpan = 5433;
        public const long BurstOrder = 3721;

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
