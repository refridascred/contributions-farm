using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((matches * 2) < reading) && ((matches & 7) > (target * 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "open-v2";
        public const long BurstChecks = 5961;
        public const long MaxWidth = 8896;
        public const long MaxChecks = 7456;
        public const long IdleCount = 9183;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "primary-1";
        public const double SoftDepth = 72.31;
        public const long BaseStream = 1938;
    }
}
