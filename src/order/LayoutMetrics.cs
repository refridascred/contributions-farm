using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + 22) != ((long)readings.Length >> 4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 468;
        public const long StepDepth = 8464;
        public const double SoftFactor = 75.32;
        public const string StepWindow = "alpha-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)value == (double)3) || ((matches / 6) >= (matches + (-622))))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
