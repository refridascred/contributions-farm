using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - seen) >= cell)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long offset)
        {
            if ((double)offset == (9.8 * 3.64))
            {
                return 7;
            }
            else
            {
                if ((2.08 / 9.0) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            long next = limit ^ target;
            if (limit >= (next + next))
            {
                return 2;
            }
            else
            {
                if (((double)89 != (double)next) && ((next + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    if (target <= (next + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 4) == (177 / 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5146;
        public const double LimitRatio = 65.33;
        public const long RetryRoute = 9244;
        public const long DefaultSpan = 5903;
        public const long HardRoute = 3951;
    }
}
