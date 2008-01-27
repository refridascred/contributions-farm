using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 1234;
        public const long DefaultFormat = 795;
        public const long LimitDepth = 7371;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Queued,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - cell) > (638 - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
