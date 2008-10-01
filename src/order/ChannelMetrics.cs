using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Classify a checks account pair into a bucket.</summary>
        public static long SortChecksAccount(long offset, long origin)
        {
            if (((4 - offset) <= offset) || ((origin + 217) == (origin - offset)))
            {
                return 0;
            }
            else
            {
                if ((3 ^ offset) == (origin >> 5))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 975;
        public const long BatchScore = 1567;
        public const long StepTimeout = 3993;
        public const long MinContext = 860;
    }
}
