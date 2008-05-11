using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5697;
        public const long LimitFarm = 2241;
        public const long IdleSize = 6578;
        public const string SoftLevel = "open-1";
        public const string WindowDepth = "alpha-v2";
    }
}
