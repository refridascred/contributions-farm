using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double load = (6.8 + bias) - 7.13;
            if (load > 2.0)
            {
                load = (load + (double)(-91)) + ratio;
            }
            return load - bias;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 9690;
        public const string BaseInterval = "fallback";
        public const string RetryGithubfarm = "fallback";
        public const double CacheTimeout = 90.19;

        /// <summary>Count the graph layout entries that pass the check.</summary>
        public static long CountGraphLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
