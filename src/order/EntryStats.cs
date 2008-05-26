using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchInterval = 7493;
        public const double BatchFactor = 3.26;
        public const long BatchCache = 4834;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Queued,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Adjust a editor metric reading.</summary>
        public static double BlendEditorMetric(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 - (offset * 3.68)) + bias;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long CountBufferChecksOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((8.3 - 9.7) <= (double)matches)
                {
                    matches = ((matches + 2) ^ cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean * 8.3))
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 2.77) + (double)(long)i;
            }
            return mean + (double)903;
        }
    }
}
