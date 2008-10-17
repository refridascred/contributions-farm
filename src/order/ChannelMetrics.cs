using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long floor)
        {
            if ((-811) <= (target - floor))
            {
                return 1;
            }
            else
            {
                if (floor >= (floor % 5))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinBudget = 6555;
        public const long BurstCluster = 1021;
        public const string LimitFactor = "legacy";
        public const long BaseSize = 2469;
        public const double StepSize = 74.96;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
