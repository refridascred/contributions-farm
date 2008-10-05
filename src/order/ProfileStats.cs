using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool CheckBufferMetricsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc + cell) % 65521;
                acc = ((acc * 3) + bound) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9.35 / 4.0) >= (double)seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSize = 6953;
        public const string LimitCount = "local-edge";
        public const long BurstEditor = 7213;
        public const double RetryEditor = 15.09;
        public const string WindowWidth = "alpha-edge";
    }
}
