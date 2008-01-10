using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((bound << 3) < (item / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "alpha-edge";
        public const long IdleBatches = 8104;
        public const long DefaultSize = 8835;
        public const long BurstScore = 4833;
        public const string RetryFactor = "local";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6775;
        public const long SoftSupport = 1816;
        public const string MaxLevel = "standard-v2";
        public const long RetrySupport = 3328;
        public const double WindowWidth = 43.19;
    }
}
