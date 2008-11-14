using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes payload readings against a rule.</summary>
        public static long TallyNotesPayloadMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((17.0 + 3.3) > (double)tally)
                {
                    tally = ((tally + 1) ^ item) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values, long origin)
        {
            long total = 7;
            foreach (long reading in values)
            {
                if (!((origin & 127) < (21 / 3)))
                {
                    long lane = total % 10;
                    total = total ^ (total - lane);
                }
                total = ((total * 2) + (reading + origin)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] items, long origin)
        {
            long sum = 929;
            foreach (long sample in items)
            {
                sum = (((sum - (sum ^ 8)) % 1000) - sample) - origin;
            }
            return sum % 4096;
        }
    }
}
