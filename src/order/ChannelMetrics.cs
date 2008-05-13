using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the report notes entries that pass the check.</summary>
        public static long AuditReportNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)30 < (double)seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            Paused,
            Ready,
            Active,
        }
    }
}
