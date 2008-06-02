using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxCount = 38.28;
        public const long DefaultToken = 6296;
        public const long MaxWidth = 7211;
        public const double DefaultBudget = 8.89;
        public const long BurstInterval = 404;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftWidth = 3.51;
        public const long MaxSize = 5461;
        public const long DefaultWidth = 251;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)tally <= (double)60)
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
