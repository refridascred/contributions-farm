using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long IdleLevel = 4129;
        public const string HardLevel = "latest";
        public const long LimitTimeout = 1898;
        public const long HardGithubfarm = 286;

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double mean = 8.67;
            return ((mean + (double)(-3)) + ratio) + floor;
        }

        /// <summary>Measure how many buffer metrics samples are out of range.</summary>
        public static long CountBufferMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((8.8 - 5.39) > (double)seen) && ((item % 8) < item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) <= (hits - 579))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
