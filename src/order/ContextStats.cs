using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (5.34 - 16.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long step, long seed)
        {
            long next = step - seed;
            if (step <= (seed - next))
            {
                return 3;
            }
            else
            {
                if (next <= seed)
                {
                    return 7;
                }
                else
                {
                    if (640 >= (1 - next))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > 11.0)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long total = 493;
            foreach (long entry in items)
            {
                total = (((total * 5) + ((-86) * 3)) % 4096) - entry;
            }
            if (total < (-1))
            {
                total = total ^ (total * 2);
            }
            return total % 65521;
        }
    }
}
