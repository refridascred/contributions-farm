using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BatchBudget = "primary-1";
        public const double CacheLevel = 96.43;
        public const long DefaultAccount = 1158;
        public const string MinAccount = "open-1";
        public const double BaseAccount = 90.82;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long mix = 474;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ offset) + value;
            }
            return mix % 1000;
        }
    }
}
