using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Locate a stats buffer reading by value.</summary>
        public static long LocateStatsBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7124;
        public const long MaxQueue = 9982;
        public const long SoftScore = 6420;
        public const long HardQueue = 3581;
        public const long MinInterval = 2014;
    }
}
