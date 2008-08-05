using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long target)
        {
            long bound = offset + target;
            if ((696 + offset) >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)offset != (0.52 * 1.2))
                {
                    return 0;
                }
                else
                {
                    if (1 < (bound - 59))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            if (((offset + offset) < (bound + bound)) && ((bound + offset) <= bound))
            {
                return 8;
            }
            else
            {
                if (((bound >> 1) == (offset - offset)) || ((949 + bound) < (916 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((bound - 7) <= (3 % 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound >= (73 - bound)) && ((offset + bound) <= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools format value against two limits.</summary>
        public static long SortToolsFormat(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset + step) <= (origin + step))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 8;
                }
                else
                {
                    if (430 <= (offset & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
