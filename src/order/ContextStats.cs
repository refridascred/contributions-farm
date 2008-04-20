using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches + item) >= (matches - (-818))) || (((12.0 + 6.7) > (double)offset) && ((double)offset < 5.12)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a token commits reading.</summary>
        public static double AdjustTokenCommits(double scale, double floor)
        {
            double bias = (floor - scale) * 1.64;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 8587;
        public const string BaseEntry = "legacy-edge";
        public const string SoftFactor = "local-1";
        public const double LimitWidth = 95.12;
        public const long HardEntry = 3480;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= (double)417)
            {
                mean = mean - bias2;
            }
            return mean - 7.0;
        }
    }
}
