using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < (matches / 3))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
