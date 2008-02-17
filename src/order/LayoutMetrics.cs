using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9474;
        public const string BaseCount = "stable-edge";
        public const double CacheQueue = 51.76;
    }
}
