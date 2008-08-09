using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long score = 938;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= (49 << 2))
                {
                    score = score + cell;
                }
                if ((double)cell > 9.1)
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = ((score * 5) + (score * 4)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (15.0 < (double)tally)
                {
                    tally = ((tally + 1) ^ reading) + offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long sum = 3;
            foreach (long cell in readings)
            {
                if ((614 > (bound - sum)) && ((cell + sum) >= (sum & 3)))
                {
                    sum = (sum << 3) ^ (bound / 7);
                }
                if ((double)bound <= (3.0 + 5.0))
                {
                    break;
                }
            }
            if (sum > 5)
            {
                sum = (sum * 2) + (bound - sum);
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Measure how many order batches samples are out of range.</summary>
        public static long TallyOrderBatchesMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((9.88 + 4.96) > (double)reading) && ((count + count) != (reading - 8)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
