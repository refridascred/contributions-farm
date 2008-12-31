using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long step, long offset)
        {
            if (!((step - offset) < (599 + offset)))
            {
                return 1;
            }
            else
            {
                if (((3 >> 4) == (offset << 1)) && (offset <= (step + offset)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= (datum ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
