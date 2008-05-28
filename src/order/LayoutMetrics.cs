using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstLevel = 241;
        public const double BaseSchema = 41.96;
        public const double DefaultSchema = 53.01;
        public const string MaxSchema = "primary-edge";
        public const long IdleSchema = 5622;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
