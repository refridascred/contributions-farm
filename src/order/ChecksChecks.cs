using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Queued,
            Closed,
            New,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Closed,
            Retry,
            Pending,
            Draft,
        }
    }
}
