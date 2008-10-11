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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((limit & 63) != (31 / 2)) || ((double)tally == (4.8 - 5.0))) || (((double)tally >= (double)item) && ((tally ^ 31) >= (item & 31))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long LookupChannelEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
