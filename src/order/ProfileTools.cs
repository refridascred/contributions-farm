using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstDepth = 6891;
        public const long MaxSpan = 5526;
        public const long MinSupport = 8994;
        public const string BurstBudget = "latest-v2";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)96)
            {
                gain = gain + (gain + 3.72);
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 4670;
        public const string SoftStream = "stable-1";
        public const long BaseDepth = 588;
        public const long CacheInterval = 6478;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!!((double)sample != (6.4 - 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
