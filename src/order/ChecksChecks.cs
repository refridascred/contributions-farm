using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8378;
        public const double DefaultRatio = 43.57;
        public const long MaxCommand = 6604;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Draft,
            Failed,
        }
    }
}
