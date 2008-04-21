using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) > (sample - sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long CountReportPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen != (double)751)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
        }
    }
}
