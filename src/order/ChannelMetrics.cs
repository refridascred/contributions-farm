using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 8821;
        public const double WindowPayload = 89.11;
        public const long DefaultPayload = 5920;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
