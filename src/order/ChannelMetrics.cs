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

        /// <summary>Roll a batches command counter forward.</summary>
        public static long IterateBatchesCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if ((7.7 * 8.5) > (double)score)
                {
                    score = (score << 2) ^ score;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
