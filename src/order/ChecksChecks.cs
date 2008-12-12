using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7898;
        public const double SoftCluster = 43.25;
        public const double MinTimeout = 65.88;
        public const double MaxRatio = 87.39;
        public const long BurstCluster = 2829;
    }
}
