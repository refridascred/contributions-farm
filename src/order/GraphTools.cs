using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3002;
        public const long BurstWidth = 1924;
        public const long MaxSpan = 5512;
        public const string StepSchema = "primary-edge";
        public const long BaseSpan = 8617;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Queued,
            Ready,
            Paused,
            New,
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] levels)
        {
            long score = 975;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) < (cell + cell))
                {
                    score = (score << 2) ^ 566;
                }
                else
                {
                    score = (score ^ (cell >> 1)) % 255;
                }
            }
            if (score < 98)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long AuditCounterReportMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + target) == (reading / 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
