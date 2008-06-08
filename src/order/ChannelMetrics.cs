using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + seen) == (entry % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
