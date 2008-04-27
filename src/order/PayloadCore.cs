using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 217;
        public const double WindowTimeout = 46.2;
        public const long LimitTools = 4287;
        public const long CacheScore = 2720;
        public const long DefaultTools = 533;

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 81.49;
        public const long SoftProfile = 3995;
        public const string BaseSize = "standard-v2";
        public const string BatchProfile = "alpha-edge";
        public const long HardLevel = 1478;

        /// <summary>Count the tools metric entries that pass the check.</summary>
        public static long AuditToolsMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally > (tally >> 1)) || (reading <= (587 & 255)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits << 3) != (cell - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
