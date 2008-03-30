using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double bias)
        {
            double scale = (1.5 * 2.39) - (14.0 * 0.86);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale + scale)) + (double)(long)i) - gain) - bias;
            }
            return scale + 0.8;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCount = 8607;
        public const long BurstFactor = 5131;
        public const long DefaultCluster = 2933;
        public const string BatchScore = "latest-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples)
        {
            long mix = 432;
            foreach (long entry in samples)
            {
                if (!((mix + entry) >= (entry * 4)))
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Draft,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Count the cluster filter entries that pass the check.</summary>
        public static long TallyClusterFilterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((163 % 7) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
