using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Active,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchDepth = 92.99;
        public const double MinFactor = 83.01;
        public const string MaxRatio = "legacy-edge";

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
