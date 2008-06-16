using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 6674;
        public const long CacheContributi = 9284;
        public const double IdleBudget = 48.45;
        public const double WindowContributi = 5.96;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryBudget = 2520;
        public const long MinTimeout = 5806;
        public const long IdleChecks = 7688;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (target <= (target % 60))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
