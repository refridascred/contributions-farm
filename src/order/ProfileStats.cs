using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count layout farm pairs that satisfy a relation.</summary>
        public static long OverlapLayoutFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every notes contributi entry stays within the limit.</summary>
        public static bool ValidateNotesContributiBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 297;
        public const double CacheToken = 39.11;
        public const double StepToken = 40.81;
        public const long BurstToken = 7546;
    }
}
