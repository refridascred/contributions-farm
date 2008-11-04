using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long offset)
        {
            if ((double)limit == (4.13 - 1.93))
            {
                return 4;
            }
            else
            {
                if (offset < (738 << 2))
                {
                    return 5;
                }
                else
                {
                    if (4.95 >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit < offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 4077;
        public const long BaseScore = 8109;
        public const long LimitStream = 2157;
        public const long MaxDepth = 3456;
        public const long CacheScore = 4569;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long limit, long floor)
        {
            if ((limit % 12) <= (limit << 3))
            {
                return 1;
            }
            else
            {
                if ((floor ^ 64) != (limit & 1))
                {
                    return 4;
                }
                else
                {
                    if ((floor - floor) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor >= (floor - floor)) || (limit > (floor - limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
