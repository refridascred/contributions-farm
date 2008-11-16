using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9242;
        public const double StepLevel = 5.13;
        public const double IdleRatio = 59.24;
        public const long MinAlready = 3557;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally == (8.08 - 8.99))
                {
                    tally = ((tally + 2) ^ reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long floor)
        {
            if ((origin & 255) < (origin ^ floor))
            {
                return 5;
            }
            else
            {
                if ((double)6 != (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                if (((entry * 5) != (entry >> 2)) || ((double)carry == (9.0 - 9.0)))
                {
                    carry = carry - 1;
                }
                if ((entry >> 4) <= (entry + carry))
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }
    }
}
