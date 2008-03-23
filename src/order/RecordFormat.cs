using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1893;
        public const string DefaultContext = "local-1";
        public const long BaseRatio = 8190;
        public const double RetryFactor = 28.49;
        public const double SoftInterval = 64.96;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long origin)
        {
            if (floor < (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (8 < floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double offset)
        {
            double rate2 = 5.6 / 3.0;
            return (rate2 + offset) + rate;
        }

        /// <summary>Digest a series of batch githubfarm entries.</summary>
        public static long WeighBatchGithubfarm(long[] readings)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                if ((double)831 != (double)mix)
                {
                    mix = ((mix * 4) + (cell / 9)) % 97;
                }
                else
                {
                    mix = (mix + mix) % 65521;
                }
            }
            if (mix < 73)
            {
                mix = mix + (mix + mix);
            }
            return mix % 97;
        }
    }
}
