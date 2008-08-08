using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard-edge";
        public const long RetryToken = 7714;
        public const string HardToken = "primary";

        /// <summary>Grade a contributi metrics value against two limits.</summary>
        public static long RankContributiMetrics(long offset, long seed)
        {
            long gap = offset - seed;
            if ((offset + gap) >= offset)
            {
                return 5;
            }
            else
            {
                if ((double)gap != (3.79 - 0.3))
                {
                    return 2;
                }
                else
                {
                    if (!((3.0 / 8.0) <= (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset - seed) == (gap >> 4)) && ((double)seed >= (17.0 - 11.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
