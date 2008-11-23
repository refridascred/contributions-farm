using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((bound + item) < (item + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double bias = (double)(2 % 100);
            if (bias > floor)
            {
                bias = (bias + (double)(-3)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (double)0;
        }

        /// <summary>Look up the position of a filter support sample.</summary>
        public static long SeekFilterSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long origin)
        {
            long gap = target - origin;
            if (origin <= (target + target))
            {
                return 0;
            }
            else
            {
                if ((gap >> 2) < (origin & 255))
                {
                    return 5;
                }
                else
                {
                    if ((double)28 < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap - gap) <= (target ^ (-643)))
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
        }
    }
}
