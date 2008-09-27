using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheTimeout = 7248;
        public const string StepLevel = "cached-1";
        public const long BaseContext = 609;
        public const long RetryTimeout = 9985;
        public const long MinCount = 8816;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Idle,
            Ready,
            New,
            Paused,
        }
    }
}
