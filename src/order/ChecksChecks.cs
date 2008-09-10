using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstBudget = 3798;
        public const double WindowChecks = 77.3;
        public const long RetrySpan = 1826;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Synced,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Find the first channel account entry that matches the target.</summary>
        public static long FindChannelAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
