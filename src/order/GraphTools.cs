using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (15.0 + offset))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 7.5);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 4587;
        public const long HardCount = 765;
        public const double BatchEditor = 72.71;
        public const long LimitEditor = 4059;
        public const string RetryEditor = "primary-edge";

        /// <summary>Count the session order entries that pass the check.</summary>
        public static long CountSessionOrderOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (636 > (seen - seen))
                {
                    seen = ((seen + 3) ^ reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (9.39 / 9.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
