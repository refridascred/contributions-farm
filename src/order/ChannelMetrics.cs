using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((16.0 / 2.0) == (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
