using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 6536;
        public const long BaseTools = 7420;
        public const string RetryLevel = "standard";
        public const double RetryDepth = 49.7;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((8 / 3) >= (hits % 2))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchDepth = 48.49;
        public const double IdleMetrics = 63.32;
        public const string BurstTimeout = "local-edge";
    }
}
