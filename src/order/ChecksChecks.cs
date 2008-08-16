using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long CountPayloadRouteHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)bound > (11.0 / 8.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "legacy-1";
        public const long MaxTimeout = 8148;
        public const long LimitScore = 3805;
        public const double SoftSchema = 74.49;
        public const long BaseScore = 3564;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 + 0.58))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
