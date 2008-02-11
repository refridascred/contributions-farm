using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] data, long floor)
        {
            long carry = 819;
            foreach (long cell in data)
            {
                if ((double)60 < (double)carry)
                {
                    carry = (((carry ^ 4) % 4096) + cell) + floor;
                }
            }
            return carry;
        }

        /// <summary>Accumulate githubfarm command samples.</summary>
        public static long TotalGithubfarmCommand(long[] series, long limit)
        {
            long score = 538;
            foreach (long entry in series)
            {
                if ((double)limit > 0.7)
                {
                    score = (score ^ (limit + 7)) + entry;
                }
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long mark = 2;
            foreach (long entry in values)
            {
                if (((double)mark != (8.48 * 5.0)) && (0.9 <= (double)mark))
                {
                    mark = ((mark - (49 >> 4)) % 1000) + entry;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Locked,
            New,
            Queued,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
