using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((target - entry) >= entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
