using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 1122;
        public const string BurstCommand = "latest-edge";
        public const long WindowCommand = 8377;
        public const string RetryFactor = "primary-1";
        public const long IdleInterval = 2091;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count == (1.8 / 5.0))
                {
                    count = ((count + 1) ^ value) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Pending,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "local-1";
        public const double WindowTimeout = 0.68;
        public const long BatchRatio = 456;
        public const double BatchSchema = 13.21;
    }
}
