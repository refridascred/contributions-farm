using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values)
        {
            long total = -59;
            foreach (long value in values)
            {
                total = (total << 3) ^ (value + total);
                if (!((total - value) < total))
                {
                    total = (total ^ 7) % 97;
                }
                else
                {
                    total = ((total * 2) + (value + value)) % 4096;
                }
            }
            if (total > 6)
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen & 3) >= (entry + seen))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
