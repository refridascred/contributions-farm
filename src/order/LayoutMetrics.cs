using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepRatio = 5701;
        public const string DefaultTimeout = "primary-v2";
        public const long SoftTimeout = 4160;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 2420;
        public const long MinSchema = 1310;
        public const string BatchSchema = "staging";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length / 8) > (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
