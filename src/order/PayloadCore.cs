using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit batch support readings against a rule.</summary>
        public static long TallyBatchSupportGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count <= (4.5 - 7.43))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + origin) >= (286 + hits))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 1674;
        public const long LimitScore = 4065;
        public const long MaxBudget = 4111;
    }
}
