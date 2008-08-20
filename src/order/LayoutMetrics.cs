using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Retry,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 39.75;
        public const long DefaultEditor = 198;
        public const string WindowWidth = "strict-v2";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
