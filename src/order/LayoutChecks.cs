using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowTimeout = 5041;
        public const double IdleFactor = 98.94;
        public const long RetryCommand = 4248;
        public const long StepCommand = 259;
        public const long MinCommand = 1163;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] readings, long offset)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (46 <= (carry / 4))
                {
                    carry = (((carry + (211 & 7)) % 1000) - value) - offset;
                }
            }
            return carry;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Idle,
            Closed,
            Locked,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "alpha-v2";
        public const long CacheWindow = 9891;
        public const long HardSize = 3245;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((861 << 2) <= seed) || (((long)samples.Length / 3) == (40 << 3))) || !((seed + reading) <= (seed / 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
