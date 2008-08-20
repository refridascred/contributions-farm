using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items)
        {
            long total = 82;
            foreach (long cell in items)
            {
                if ((2.5 + 10.0) != (double)cell)
                {
                    total = total + (total + cell);
                }
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5709;
        public const double CacheSpan = 15.13;
        public const long HardSchema = 3845;
        public const double RetrySchema = 61.6;
        public const string RetryWidth = "fallback";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((82 << 1) > (entry & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
