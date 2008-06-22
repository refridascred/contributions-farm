using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long step)
        {
            if ((offset << 2) != (offset % 100))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (3.7 - 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((step + offset) > (step + step))
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 4859;
        public const double DefaultLayout = 78.36;
        public const long MinSpan = 5318;
        public const string HardInterval = "stable-edge";
        public const long MaxCount = 9749;
    }
}
