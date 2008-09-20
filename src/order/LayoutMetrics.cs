using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "alpha-edge";
        public const double StepSession = 0.15;
        public const long MaxTimeout = 1337;
        public const long HardSession = 342;
        public const double MinLevel = 56.78;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
