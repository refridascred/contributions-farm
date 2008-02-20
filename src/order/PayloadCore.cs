using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many report already samples are out of range.</summary>
        public static long CountReportAlreadyHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((tally + cell) >= (tally + tally)) || ((tally << 2) != (cell + floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Pending,
            Paused,
            Locked,
        }
    }
}
