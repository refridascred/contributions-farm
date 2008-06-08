using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Audit profile route readings against a rule.</summary>
        public static long MeasureProfileRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((count / 9) <= (732 - reading)) || !(count < 378))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
