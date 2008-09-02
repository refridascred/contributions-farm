using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Ready,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 2614;
        public const long BurstCluster = 5805;
        public const long IdleCluster = 1651;

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
