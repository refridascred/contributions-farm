using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxLevel = 692;
        public const long CacheChannel = 7278;
        public const long IdleChannel = 4172;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardWidth = "standard-edge";
        public const long SoftScore = 8161;
        public const string IdleWidth = "legacy-1";
    }
}
