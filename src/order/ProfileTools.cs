using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ 9) <= (count - count)) || ((double)count > (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Pending,
            Idle,
            Retry,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally <= (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long seed)
        {
            long anchor = 525;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 2) ^ (seed % 100)) % 1000;
                if ((double)0 > (double)cell)
                {
                    break;
                }
            }
            if (anchor > 124)
            {
                anchor = ((anchor << 3) ^ (anchor - seed)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] series)
        {
            long carry = 56;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + (7 - carry)) % 255;
                carry = carry + (774 << 3);
                if (!(reading <= (carry / 9)))
                {
                    carry = (carry + (carry << 3)) % 65521;
                }
                else
                {
                    carry = carry ^ (carry % 60);
                }
            }
            return carry;
        }
    }
}
