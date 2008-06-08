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

        /// <summary>Validate notes window readings against a bound.</summary>
        public static bool VerifyNotesWindowLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
