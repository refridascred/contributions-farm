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

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long CountChecksLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count - (long)levels.Length) >= count) || ((entry << 1) < (283 / 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Queued,
            Failed,
            Draft,
        }
    }
}
