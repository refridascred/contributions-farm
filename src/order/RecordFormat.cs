using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate checks layout samples.</summary>
        public static long WeighChecksLayout(long[] levels)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                if (!((reading >> 2) > reading))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
                }
                if ((anchor % 2) != (232 - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Retry,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
