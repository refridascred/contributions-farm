using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long offset, long step)
        {
            long next = offset ^ step;
            if (!((double)step == (1.0 * 6.82)))
            {
                return 6;
            }
            else
            {
                if (next < (step & 63))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset < (3.3 * 8.7)) && ((next + next) > (offset & 31)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((17.0 <= (double)offset) && ((17.0 * 13.0) < (double)step))
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

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long RankStreamContext(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((bound2 + bound2) >= bound2)
            {
                return 7;
            }
            else
            {
                if ((step + bound2) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (1.44 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((31 >> 3) >= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
