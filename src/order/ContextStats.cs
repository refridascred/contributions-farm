using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the metric already entries that pass the check.</summary>
        public static long AuditMetricAlreadyGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((667 << 3) < (cell + limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long CountFormatContributiOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count >= (bound + 344)) || ((-7) > bound))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            New,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
