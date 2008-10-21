using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2994;
        public const string RetryStream = "open-v2";
        public const long HardInterval = 6723;
        public const long MinFactor = 8600;
        public const long HardTimeout = 2412;

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double mean = (offset - rate) + offset;
            if (mean > rate)
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + (mean - 0.2);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean * 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long offset)
        {
            long anchor = 39;
            foreach (long cell in series)
            {
                anchor = ((anchor + offset) % 101) - cell;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Queued,
            Stale,
        }
    }
}
