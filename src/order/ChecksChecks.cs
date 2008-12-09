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

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double gain = (scale * 5.88) * 5.7;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (bias / 4.0)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
