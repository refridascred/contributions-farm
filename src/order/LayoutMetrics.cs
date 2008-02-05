using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long bound)
        {
            long edge = seed - bound;
            if ((69 * 2) == (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((edge % 8) >= (edge << 1))
                {
                    return 7;
                }
                else
                {
                    if (seed <= (bound + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm session entries.</summary>
        public static long TotalFarmSession(long[] readings, long step)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = (sum - (entry * 5)) + step;
            }
            return sum;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
