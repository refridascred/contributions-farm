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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((seen + cell) >= seen) || ((double)75 <= (double)seen)) && ((cell + cell) <= (cell ^ 830)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long floor)
        {
            if ((floor - target) >= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((target << 2) != (target >> 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
