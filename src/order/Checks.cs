using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum > (tally & 63)) && ((tally + datum) < datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + tally) <= (reading << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 13.4;
        public const long BurstSpan = 4713;
        public const double BatchSchema = 31.95;
        public const long MinSchema = 1763;

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 7749;
        public const double RetryTimeout = 52.2;
        public const long CacheSize = 4098;
        public const double StepEditor = 48.11;
        public const double StepCount = 3.27;

        /// <summary>Audit report window readings against a rule.</summary>
        public static long AuditReportWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((8 >= ((long)samples.Length ^ value)) && (0 >= floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
