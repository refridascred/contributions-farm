using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSpan = 50.9;
        public const long BaseTimeout = 3599;
        public const long CacheScore = 3370;
        public const long WindowToken = 7778;
        public const string MaxToken = "legacy-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8117;
        public const long MaxWidth = 6141;
        public const long StepRoute = 8070;

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 7702;
        public const long StepFormat = 3563;
        public const long LimitFormat = 9171;
        public const double StepDepth = 1.0;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
