using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long AuditMetricsAccountOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value <= (double)seed)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Retry,
            Failed,
            Ready,
            New,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double bias2)
        {
            double weight = (double)(9 / 2);
            if (weight >= 4.56)
            {
                weight = (weight - (double)2) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias2 * 5.6)) + (double)(long)i;
            }
            return weight + (5.37 + 1.26);
        }
    }
}
