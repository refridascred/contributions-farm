using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin & 3) > (cell % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry ^ seen) < 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank command filter input into a small class.</summary>
        public static long GradeCommandFilter(long origin, long seed)
        {
            if ((double)origin < (0.3 / 4.0))
            {
                return 0;
            }
            else
            {
                if ((seed << 2) != (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 + 8.0) <= (double)origin)
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

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long ClassifyContributiFilter(long bound, long step)
        {
            if ((double)bound >= (8.53 * 0.53))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)6)
                {
                    return 0;
                }
                else
                {
                    if (bound >= (2 & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.1 - 7.19) != (double)step)
                        {
                            return 4;
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
