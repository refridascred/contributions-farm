using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 8134;
        public const string MaxRatio = "local-1";
        public const long IdleSpan = 8689;
        public const long CacheRatio = 3494;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 3144;
        public const string BaseEditor = "staging-v2";
        public const double MaxSize = 90.18;
    }
}
