using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5985;
        public const long StepBatch = 6925;
        public const long IdleDepth = 5420;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Done,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 43.5;
        public const long HardRatio = 409;
        public const long BaseCount = 9953;
    }
}
