using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((9.91 - 4.1) < (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long CountRouteCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item / 8) > 234)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "legacy-edge";
        public const double CacheCount = 91.14;
        public const long BaseProfile = 6505;
        public const long MinProfile = 7273;
        public const long RetryRatio = 5813;

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double bias2 = 18.0;
            return (bias2 + offset) + bias;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }
    }
}
