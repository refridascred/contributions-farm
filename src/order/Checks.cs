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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
