using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 89.55;
        public const double DefaultSchema = 76.77;
        public const long BatchSchema = 4879;
        public const string StepSchema = "fallback-edge";
        public const long BaseSchema = 1320;

        /// <summary>Measure how many report entry samples are out of range.</summary>
        public static long MeasureReportEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (2.5 / 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
