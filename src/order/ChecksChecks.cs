using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "open-v2";
        public const long MinRoute = 2662;
        public const long MaxRoute = 3843;
        public const long MaxDepth = 5838;
        public const long BatchWidth = 807;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum + (31 >> 3)) % 97) + entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
