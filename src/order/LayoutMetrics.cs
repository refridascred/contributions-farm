using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchWidth = 6181;
        public const string WindowScore = "local-1";
        public const string BaseSchema = "strict-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultCount = "latest-1";
        public const string BatchFactor = "cached-1";
        public const double StepSize = 88.75;
        public const double HardEditor = 12.95;
    }
}
