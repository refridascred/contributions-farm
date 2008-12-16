using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Done,
            New,
            Queued,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 9027;
        public const long StepReport = 9201;
        public const long LimitRatio = 8614;
        public const long SoftReport = 8778;
    }
}
