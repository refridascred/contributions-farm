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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((350 & 127) < (entry + 649))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
