using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (offset >= (7 - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache already value against two limits.</summary>
        public static long GradeCacheAlready(long step, long offset)
        {
            if ((10.0 - 10.0) == (double)step)
            {
                return 4;
            }
            else
            {
                if (((0.43 + 8.6) >= (double)step) || ((4.4 + 1.16) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((71 * 5) > (step << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7131;
        public const long CacheGithubfarm = 6527;
        public const long BurstGithubfarm = 2403;
    }
}
