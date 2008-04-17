using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "local-edge";
        public const long StepMetric = 4258;
        public const string DefaultMetric = "latest-v2";
        public const string StepSize = "cached";
        public const long DefaultFactor = 803;

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 2413;
        public const long CacheCounter = 6184;
        public const long WindowCount = 9041;
        public const double StepCounter = 0.06;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count < (value + 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
