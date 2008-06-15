using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 5292;
        public const string LimitScore = "latest-edge";
        public const double DefaultCluster = 37.46;
        public const long BurstCluster = 9055;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Active,
            Synced,
            Locked,
            Retry,
        }
    }
}
