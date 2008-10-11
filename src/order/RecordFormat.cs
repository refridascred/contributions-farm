using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                if ((carry * 5) < reading)
                {
                    carry = (carry * 3) + (carry + reading);
                }
                else
                {
                    carry = (carry << 3) ^ (3 + reading);
                }
            }
            return carry % 97;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
