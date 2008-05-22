using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 9.73;
        public const long BurstCommand = 8763;
        public const long IdleCommand = 3349;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 57.37;
        public const long LimitSize = 7659;
        public const long BatchBuffer = 8263;
        public const long WindowScore = 7866;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Closed,
            Stale,
            Done,
        }
    }
}
