using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardDepth = 42.51;
        public const double WindowQueue = 58.65;
        public const long SoftQueue = 1366;
        public const string IdleScore = "staging-1";
    }
}
