using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 41.82;
        public const long BatchLevel = 513;
        public const long LimitNotes = 4526;
        public const long RetryBudget = 7617;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Synced,
            Active,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleSize = 64.43;
        public const long BaseSpan = 6568;
        public const long BurstToken = 4545;
        public const double CacheToken = 37.67;

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
