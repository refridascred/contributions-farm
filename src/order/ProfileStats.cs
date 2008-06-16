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

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels, long origin)
        {
            long acc = -403;
            foreach (long reading in levels)
            {
                if ((97 & 1) == (origin >> 2))
                {
                    acc = ((acc * 4) + (origin * 3)) + reading;
                }
            }
            if (acc < 17)
            {
                acc = ((acc << 3) ^ (origin / 5)) % 4096;
            }
            return acc % 1000;
        }

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
