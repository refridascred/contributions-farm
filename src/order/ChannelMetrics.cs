using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value <= (7.26 - 8.23))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - seen) <= value)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
