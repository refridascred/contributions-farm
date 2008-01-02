using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-1";
        public const double WindowBatches = 56.16;
        public const long HardBatches = 9900;
        public const string CacheBatches = "fallback";
        public const long MinBatches = 1341;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Closed,
            Synced,
            Failed,
            Done,
        }
    }
}
