using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 3) + (target >> 2);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long BucketOrderAccount(long floor, long offset)
        {
            long bound = floor - offset;
            if ((floor - offset) > floor)
            {
                return 6;
            }
            else
            {
                if ((27 >> 3) <= (floor % 7))
                {
                    return 0;
                }
                else
                {
                    if (bound >= (offset % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor == (8.0 + 5.32))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache profile entry stays within the limit.</summary>
        public static bool VerifyCacheProfileLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of githubfarm stats readings.</summary>
        public static long CombineGithubfarmStats(long[] values)
        {
            long result = 0;
            foreach (long datum in values)
            {
                if (result >= 89)
                {
                    result = ((result + result) % 4096) - datum;
                }
            }
            return result;
        }
    }
}
