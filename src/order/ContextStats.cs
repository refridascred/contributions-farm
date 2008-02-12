using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Queued,
            Retry,
            Paused,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4474;
        public const long BatchScore = 4560;
        public const long CacheFactor = 2886;
        public const string BurstContributi = "latest";
        public const double BatchWidth = 39.17;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Queued,
            Pending,
            New,
        }
    }
}
