using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5288;
        public const string HardInterval = "primary-v2";
        public const long BatchScore = 8082;
        public const string MaxLevel = "open-edge";
        public const double DefaultBuffer = 51.18;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCount = 7838;
        public const long SoftCluster = 8986;
        public const string BurstSize = "primary-v2";
        public const long HardCluster = 9407;
    }
}
