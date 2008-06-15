using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= 899)
                {
                    hits = ((hits + 2) ^ entry) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 5195;
        public const long StepChannel = 1906;
        public const long HardScore = 3621;
        public const string MinFactor = "latest-v2";

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 7580;
        public const double BaseEntry = 74.79;
        public const double BatchScore = 20.61;
        public const string IdleEntry = "stable";
        public const long BatchEntry = 1376;
    }
}
