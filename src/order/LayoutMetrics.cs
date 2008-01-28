using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) > (188 + 758))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Ready,
            Failed,
            Idle,
            Closed,
        }
    }
}
