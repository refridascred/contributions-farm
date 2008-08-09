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

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Draft,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
