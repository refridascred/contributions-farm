using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Measure how many context payload samples are out of range.</summary>
        public static long AuditContextPayloadOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item % 3) <= (seed + seed)) && (item > (48 - (-16))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((sum % 5) <= sum)
                {
                    continue;
                }
                sum = sum - (origin * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
