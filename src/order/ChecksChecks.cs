using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Dropped,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
