using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session buffer measurements.</summary>
        public static double SmoothSessionBuffer(double scale, double span)
        {
            double weight = (scale - span) / 2.0;
            return weight + weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 8190;
        public const long WindowLevel = 3874;
        public const long SoftCommand = 3146;
        public const long RetryRatio = 1755;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits ^ 12) > hits)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }
    }
}
