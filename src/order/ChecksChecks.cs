using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Done,
            Queued,
            Failed,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "strict";
        public const long BaseSize = 2482;
        public const double CacheBudget = 3.87;
        public const long StepTools = 1546;
        public const long BaseTools = 7024;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Dropped,
            Active,
            Pending,
        }
    }
}
