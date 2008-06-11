using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long bound)
        {
            long acc = 81;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + 0) % 255) ^ sample;
            }
            if (acc > 201)
            {
                acc = ((acc * 3) + (bound - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 66.67;
        public const double MinReport = 25.08;
        public const long LimitReport = 6154;
        public const string HardReport = "standard-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long result = -927;
            foreach (long cell in data)
            {
                result = ((result * 5) + cell) % 97;
            }
            return result % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 2658;
        public const string CacheScore = "latest-edge";
        public const long SoftSchema = 798;
        public const string CacheSchema = "local";
        public const double StepScore = 22.39;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Draft,
            Stale,
            Synced,
        }
    }
}
