using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((4.0 / 8.0) > (double)value))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((7.0 / 3.0) <= (double)count)
                {
                    count = ((count + 2) + cell) + step;
                }
            }
            return count;
        }
    }
}
