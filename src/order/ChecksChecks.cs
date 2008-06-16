using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long limit)
        {
            long delta = seed + limit;
            if (seed > (seed >> 2))
            {
                return 3;
            }
            else
            {
                if (224 <= (delta % 16))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed >= (7.86 + 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit record commits readings against a rule.</summary>
        public static long AuditRecordCommitsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((183 ^ tally) == (target + 462)) && ((target <= ((-65) / 6)) || ((double)target != (4.45 - 7.0))))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long total = 67;
            foreach (long value in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (((total * 5) + total) - (long)i) - value;
                }
                if ((6.0 + 9.02) < (double)total)
                {
                    total = total ^ (total << 1);
                }
            }
            return total;
        }
    }
}
