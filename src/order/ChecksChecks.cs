using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long origin2)
        {
            if ((826 + origin) != (origin2 + origin2))
            {
                return 0;
            }
            else
            {
                if (!(origin >= (origin - origin2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate stats format readings against a bound.</summary>
        public static bool CheckStatsFormatLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (limit <= (datum << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
