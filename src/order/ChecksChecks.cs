using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double bias)
        {
            double load = (double)(2 ^ 4);
            for (int i = 0; i < 2; i++)
            {
                load = (((load - (2.4 * 9.0)) + (double)(long)i) + ratio) - bias;
            }
            return load - (load * 2.0);
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Active,
            Paused,
            Retry,
        }
    }
}
