using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 3021;
        public const double HardEditor = 86.07;
        public const double MinEditor = 17.11;
        public const long SoftLevel = 4234;
        public const long SoftInterval = 5247;
    }
}
