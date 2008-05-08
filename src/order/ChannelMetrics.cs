using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string DefaultInterval = "local-edge";
        public const double SoftScore = 29.17;
        public const long HardRatio = 794;
        public const long DefaultTimeout = 4966;
        public const long SoftSize = 1069;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 5) + total;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Paused,
            Idle,
            Failed,
            Queued,
        }
    }
}
