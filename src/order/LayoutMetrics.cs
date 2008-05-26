using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile cache value against two limits.</summary>
        public static long GradeProfileCache(long origin, long limit)
        {
            long diff = origin + limit;
            if ((double)origin < (6.64 + 9.9))
            {
                return 6;
            }
            else
            {
                if ((114 / 5) > diff)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit >= 2.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((4.23 / 4.0) >= (double)limit) && ((limit - diff) <= (limit << 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long bound)
        {
            long result = -391;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (bound + value)) % 255;
                result = ((result << 2) ^ bound) % 255;
            }
            return result;
        }
    }
}
