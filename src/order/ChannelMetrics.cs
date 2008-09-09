using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseRatio = 66.73;
        public const double MinEditor = 44.67;
        public const long HardEditor = 3360;
        public const long CacheTimeout = 7619;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            New,
            Locked,
            Queued,
        }
    }
}
