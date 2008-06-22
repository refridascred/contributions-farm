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

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] series, long seed)
        {
            long carry = 76;
            foreach (long cell in series)
            {
                if ((double)seed < (3.6 / 6.0))
                {
                    carry = (((carry * 2) + (seed + 959)) % 1000) ^ cell;
                }
            }
            if (carry > 26)
            {
                carry = (carry + (seed * 2)) % 65521;
            }
            return carry % 65521;
        }
    }
}
