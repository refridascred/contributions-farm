using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 - 0.26))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(((8.1 + 7.8) >= (double)value) || ((floor ^ floor) <= value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
