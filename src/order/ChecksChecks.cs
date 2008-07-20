using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            New,
            Retry,
            Synced,
        }

        /// <summary>Iterate the contributi entry series from a seed.</summary>
        public static long StepContributiEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (double)202)
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (1.94 + 3.8)) + (double)(long)i;
            }
            return weight2 - 0.91;
        }
    }
}
