using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (9.65 * 7.0))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Queued,
            Stale,
            Paused,
        }
    }
}
