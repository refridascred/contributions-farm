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

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double gain = span;
            if (gain < weight)
            {
                gain = gain + (double)593;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain + span)) + (double)(long)i;
            }
            return gain + (double)2;
        }
    }
}
