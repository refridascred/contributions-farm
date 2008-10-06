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

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long SeekFarmLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
