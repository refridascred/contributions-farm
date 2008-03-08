using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Draft,
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftRatio = 832;
        public const double BaseSize = 67.23;
        public const long MinCluster = 4099;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 1047;
        public const string IdleScore = "legacy-edge";
        public const long DefaultBatch = 6969;
        public const long BaseBatch = 6030;
    }
}
