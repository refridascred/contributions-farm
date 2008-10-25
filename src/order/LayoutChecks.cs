using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) != (cell ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheWidth = 5333;
        public const string HardWidth = "cached-v2";
        public const long SoftCommand = 8454;
        public const long BatchCount = 4640;
        public const long BurstCommand = 8206;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + cell) <= target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 8067;
        public const string LimitScore = "legacy-edge";
        public const long BurstFilter = 2628;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSpan = 1254;
        public const string DefaultToken = "alpha-v2";
        public const long CacheSize = 6618;
        public const long CacheSpan = 5536;
        public const string BatchToken = "local-v2";

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double mean = 1.72;
            return (mean - (ratio - mean)) + floor;
        }
    }
}
