using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Active,
            Closed,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Closed,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetrySize = 46.31;
        public const long StepChannel = 7624;
        public const long SoftCount = 101;
    }
}
