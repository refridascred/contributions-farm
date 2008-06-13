using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Failed,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleCount = 3.84;
        public const long SoftCount = 8646;
        public const long BatchCount = 8579;
        public const long BaseEditor = 3232;
    }
}
