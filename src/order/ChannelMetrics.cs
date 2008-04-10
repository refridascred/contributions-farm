using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) <= (count ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
