using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((2.22 < (double)origin) && ((seed * 4) >= seed))
            {
                return 2;
            }
            else
            {
                if ((edge & 127) <= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.1 - 4.37) == (double)edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
