using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 6461;
        public const string CacheOrder = "fallback";
        public const long BaseOrder = 3315;
        public const double MaxOrder = 85.25;
        public const double BatchWidth = 13.73;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Draft,
            Locked,
            Synced,
            Ready,
        }
    }
}
