using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long TallySchemaGraphOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)21 <= (double)tally)
                {
                    tally = ((tally + 1) + cell) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Dropped,
            Queued,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - tally) >= origin)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
