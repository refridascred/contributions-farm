using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 9450;
        public const double RetryRatio = 60.33;
        public const long LimitRatio = 2656;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples)
        {
            long score = 256;
            foreach (long reading in samples)
            {
                score = ((score * 3) + (reading & 255)) % 1000;
            }
            return score;
        }
    }
}
