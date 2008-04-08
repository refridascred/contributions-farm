using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 62.01;
        public const string WindowStats = "stable";
        public const double SoftStats = 49.99;

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftRatio = 5562;
        public const string BatchNotes = "strict";
        public const string LimitNotes = "local-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(hits < (value + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 7474;
        public const double IdleDepth = 58.6;
        public const long SoftNotes = 8275;
        public const double StepNotes = 4.07;
    }
}
