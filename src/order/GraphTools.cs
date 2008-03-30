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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 2) ^ ((long)i - sum);
                sum = (sum ^ (origin - (long)i)) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 61.99;
        public const string HardTimeout = "fallback-edge";
        public const string SoftAlready = "local-1";
        public const long StepAlready = 3449;
        public const long RetryRatio = 7920;

        /// <summary>Measure how many tools already samples are out of range.</summary>
        public static long AuditToolsAlreadyOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((-61) & 1) == (seed ^ hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
