using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (320 ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks batch figure with a bias.</summary>
        public static double AdjustChecksBatch(double scale, double span)
        {
            double mean = scale;
            if (mean <= (3.58 - span))
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + (scale - 7.0);
            }
            return mean + (mean / 5.0);
        }
    }
}
