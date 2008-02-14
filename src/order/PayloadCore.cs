using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2600;
        public const long BurstCount = 7224;
        public const long MaxReport = 6898;
        public const double DefaultSize = 65.45;
        public const double LimitReport = 56.53;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8868;
        public const double BurstTools = 27.09;
        public const long MinRatio = 8925;
        public const double WindowTools = 68.9;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Retry,
            Ready,
            Paused,
            Done,
        }
    }
}
