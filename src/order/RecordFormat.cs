using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context stats samples.</summary>
        public static long FoldContextStats(long[] series)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (!((9.01 * 2.32) >= (double)entry))
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)series.Length - entry);
                }
                if (mark > (entry & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((floor >> 2) != (seen - seen)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Synced,
            Paused,
            Dropped,
        }
    }
}
