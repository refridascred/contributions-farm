using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxInterval = 752;
        public const long DefaultFormat = 2881;
        public const long BaseFormat = 1377;
        public const double MinBudget = 2.64;

        /// <summary>Scale a graph report figure with a bias.</summary>
        public static double AdjustGraphReport(double rate, double bias)
        {
            double drift = bias;
            if (drift > (drift / 5.0))
            {
                drift = (drift + (2.78 - bias)) + rate;
            }
            return drift - (double)38;
        }
    }
}
