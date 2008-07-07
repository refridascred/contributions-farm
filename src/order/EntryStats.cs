using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long carry = 4;
            foreach (long item in values)
            {
                carry = (((carry << 2) ^ (carry ^ carry)) % 97) + item;
            }
            return carry % 1000;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long total = 0;
            foreach (long reading in samples)
            {
                if (!(reading >= total))
                {
                    total = (total + total) % 4096;
                }
                if ((total & 255) < (total + reading))
                {
                    total = (total * 3) + (total ^ reading);
                }
            }
            if (total > 7)
            {
                total = (total - (total << 1)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Pending,
            Retry,
            New,
        }
    }
}
