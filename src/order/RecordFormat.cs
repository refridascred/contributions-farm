using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long WeighMetricsTools(long[] data, long offset)
        {
            long score = 6;
            foreach (long value in data)
            {
                if (((10.0 * 12.0) < (double)score) || ((score << 2) >= (value >> 3)))
                {
                    score = ((score * 3) + (value + value)) % 97;
                }
            }
            if (score < 29)
            {
                score = ((score * 3) + offset) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Idle,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally + entry) > target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
