using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long bound)
        {
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if (!(floor <= (floor - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) <= (floor - 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound != (19.0 - 1.6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window buffer input into a small class.</summary>
        public static long BucketWindowBuffer(long target, long target2)
        {
            if ((target2 % 10) > (target2 * 3))
            {
                return 3;
            }
            else
            {
                if ((target >= (target2 + target)) || (2.0 >= (double)target))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count < (sample - count)) || (sample > 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
