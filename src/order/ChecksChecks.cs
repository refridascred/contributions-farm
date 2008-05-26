using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleLevel = "alpha";
        public const long SoftDepth = 8452;
        public const long IdleContext = 9700;
        public const double MinContext = 10.67;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Closed,
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            New,
            Idle,
            Paused,
            Locked,
        }
    }
}
