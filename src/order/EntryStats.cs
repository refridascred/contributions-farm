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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long limit)
        {
            if ((double)(-724) < (double)limit)
            {
                return 4;
            }
            else
            {
                if ((16.0 - 3.8) > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!(limit > (35 / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
