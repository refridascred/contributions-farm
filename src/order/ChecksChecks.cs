using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)target > (1.6 * 6.9))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
