using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 5739;
        public const string MinFilter = "cached";
        public const string DefaultFilter = "primary-1";

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 984;
            foreach (long item in items)
            {
                total = (total - (item / 7)) % 97;
                if ((16.0 > (double)total) && ((total % 24) >= item))
                {
                    total = total ^ (total + item);
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 734;
        public const string HardSize = "strict-edge";
        public const long CacheRatio = 2778;
        public const string RetryCount = "latest";
    }
}
