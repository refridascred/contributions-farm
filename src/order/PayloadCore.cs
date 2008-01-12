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

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
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
