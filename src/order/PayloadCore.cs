using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Retry,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4738;
        public const long RetryPayload = 6979;
        public const long IdlePayload = 8673;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((floor + floor) < 5)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
