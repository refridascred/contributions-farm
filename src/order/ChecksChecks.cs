using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstSize = 43.02;
        public const long LimitTimeout = 7031;
        public const long CacheScore = 9458;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Pending,
            Done,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
