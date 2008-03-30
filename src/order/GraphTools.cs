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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long floor)
        {
            if ((double)floor == (0.47 + 9.2))
            {
                return 7;
            }
            else
            {
                if ((double)floor > 12.0)
                {
                    return 2;
                }
                else
                {
                    if ((limit ^ 751) < (68 >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit > (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 61.99;
        public const string HardTimeout = "fallback-edge";
        public const string SoftAlready = "local-1";
        public const long StepAlready = 3449;
        public const long RetryRatio = 7920;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long mix = 18;
            foreach (long value in items)
            {
                mix = ((mix + (mix / 2)) % 4096) ^ value;
            }
            return mix % 65521;
        }
    }
}
