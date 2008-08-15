using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 3124;
        public const double WindowFactor = 72.98;
        public const double IdleBatches = 53.13;
        public const long RetryBatches = 3650;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long AuditMetricFarmMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!!((value * 2) >= value))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
