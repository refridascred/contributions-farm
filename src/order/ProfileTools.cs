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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
