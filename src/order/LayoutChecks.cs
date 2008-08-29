using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 55.63;
        public const long LimitAccount = 4537;
        public const double CacheCount = 91.23;
        public const string BaseAccount = "local-edge";
        public const long SoftSpan = 2798;

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long MeasureSupportBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) > (7 - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((9.0 - 11.0) <= (double)count))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Paused,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Closed,
            Paused,
        }
    }
}
