using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count - count) <= (count / 7))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit channel metric readings against a rule.</summary>
        public static long AuditChannelMetricMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((649 + (long)series.Length) >= tally)
                {
                    tally = ((tally + 3) - cell) - origin;
                }
            }
            return tally;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((target % 8) == (tally >> 4))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
