using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command order samples.</summary>
        public static long CompareCommandOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 583;
        public const double BaseLevel = 59.31;
        public const double SoftWidth = 38.61;
        public const long RetryContext = 7337;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Synced,
            Retry,
            Locked,
            Stale,
        }
    }
}
