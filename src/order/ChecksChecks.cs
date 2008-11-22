using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 4713;
        public const double BaseFilter = 33.85;
        public const long HardBudget = 269;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3922;
        public const string LimitScore = "staging-v2";
        public const long BaseFactor = 4278;
        public const long DefaultCluster = 6369;
    }
}
