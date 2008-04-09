using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long floor)
        {
            long slot = bound + floor;
            if (((bound & 63) <= (-64)) || ((floor + slot) < (floor - 9)))
            {
                return 2;
            }
            else
            {
                if ((bound % 10) <= 0)
                {
                    return 8;
                }
                else
                {
                    if ((floor <= (floor / 3)) || (6 > (slot + slot)))
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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long bound)
        {
            if (((0.7 - 2.0) != (double)step) || ((bound + bound) > (step & 7)))
            {
                return 4;
            }
            else
            {
                if (bound > 9)
                {
                    return 3;
                }
                else
                {
                    if ((2.0 / 2.0) < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
