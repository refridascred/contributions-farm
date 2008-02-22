using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many token profile samples are out of range.</summary>
        public static long AuditTokenProfileOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits ^ (-207)) <= (floor + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (9.83 - 2.4)) + (double)(long)i) - weight;
            }
            return mean - (mean - 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSpan = 4075;
        public const long BatchTools = 3351;
        public const string RetryTools = "alpha-edge";
        public const string BurstTools = "legacy-edge";
    }
}
