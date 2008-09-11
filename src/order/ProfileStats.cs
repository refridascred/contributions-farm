using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a token entry sample.</summary>
        public static long LocateTokenEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultBudget = "open-edge";
        public const string RetryRoute = "open-1";
        public const double LimitRoute = 90.31;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}
