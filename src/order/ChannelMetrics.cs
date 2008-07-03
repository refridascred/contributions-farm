using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 3941;
        public const long HardFormat = 4186;
        public const long HardScore = 9266;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] items, long floor)
        {
            long result = 14;
            foreach (long entry in items)
            {
                if (floor < (entry >> 1))
                {
                    result = (result - (entry + result)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Failed,
            Locked,
            Draft,
            Stale,
        }
    }
}
