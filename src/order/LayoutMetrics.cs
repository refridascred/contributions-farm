using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchSize = 6421;
        public const double BatchEntry = 75.84;
        public const long BaseSpan = 3138;

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 3259;
        public const double DefaultTimeout = 97.22;
        public const string BatchWindow = "legacy-v2";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (57 + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
