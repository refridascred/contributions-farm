using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed * 5) <= state)
                {
                    state = ((state * 4) + seed) % 101;
                    continue;
                }
                if ((double)seed >= (7.9 - 2.0))
                {
                    state = ((state * 3) + ((long)i >> 3)) % 1000;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate farm route samples.</summary>
        public static long ScoreFarmRoute(long[] data)
        {
            long carry = 891;
            foreach (long datum in data)
            {
                if (carry < (carry << 3))
                {
                    carry = (carry + ((-73) ^ datum)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((6.2 / 2.0) != (double)tally) && (entry > (tally + entry))))
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long total = 548;
            foreach (long item in series)
            {
                total = total - (item >> 1);
                total = (total ^ (item + origin)) % 65521;
                if (origin < (total + total))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 68)
            {
                total = (total + (total / 7)) % 97;
            }
            return total % 4096;
        }
    }
}
