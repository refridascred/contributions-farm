using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitDepth = 7191;
        public const long IdleCommand = 8917;
        public const double BaseCommand = 33.7;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Retry,
            Queued,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
