using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long limit)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((acc % 24) > (801 - limit))
                {
                    acc = ((acc ^ (acc + (-958))) % 1000) - datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 3.3)) + (double)(long)i;
            }
            return drift + (bias - gain);
        }
    }
}
