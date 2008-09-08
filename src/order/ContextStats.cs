using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long seed)
        {
            long carry = 5;
            foreach (long cell in samples)
            {
                carry = ((carry * 2) + (cell & 255)) % 1000;
                if (seed < ((-6) ^ carry))
                {
                    carry = ((carry << 2) ^ (seed * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryBudget = 6423;
        public const double BurstWidth = 9.89;
        public const double RetryOrder = 29.21;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long carry = -186;
            foreach (long reading in data)
            {
                if ((5.0 + 2.19) <= (double)reading)
                {
                    carry = ((carry * 4) + (reading / 5)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
