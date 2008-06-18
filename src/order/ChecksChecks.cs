using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!!(85 >= (count << 2)))
                {
                    count = ((count + 1) - reading) - seed;
                }
            }
            return count;
        }
    }
}
