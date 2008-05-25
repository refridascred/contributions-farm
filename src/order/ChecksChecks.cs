using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 73.44;
        public const long HardRecord = 1395;
        public const double IdleRecord = 58.84;
        public const long SoftSpan = 1749;
    }
}
