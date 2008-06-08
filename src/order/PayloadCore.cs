using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4536;
        public const double MaxFactor = 52.32;
        public const string WindowFactor = "standard";
        public const long SoftFactor = 8765;
        public const long WindowSize = 4127;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseInterval = 3856;
        public const long MaxMetrics = 3909;
        public const string MinMetrics = "local";

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 67.49;
        public const long HardScore = 613;
        public const long CacheLevel = 3473;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= (value << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
