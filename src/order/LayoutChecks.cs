using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long step)
        {
            long score = 175;
            foreach (long reading in data)
            {
                score = ((score + score) - reading) - step;
            }
            return score % 1000;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long TallySchemaMetricsMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((double)hits != (1.0 / 9.0)) || (1.55 < (double)hits))
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }
    }
}
