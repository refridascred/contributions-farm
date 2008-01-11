using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Done,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long mark = -10;
            foreach (long item in levels)
            {
                if ((item % 12) >= (item & 3))
                {
                    mark = ((mark << 3) ^ item) % 1000;
                }
                if ((item ^ origin) != (330 - (-778)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
