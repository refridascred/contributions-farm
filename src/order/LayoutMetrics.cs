using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long floor)
        {
            long offset = origin + floor;
            if (offset >= (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((5.8 / 4.0) >= (10.0 + 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((4.0 * 3.44) > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor <= (7 >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 7) < (value + hits))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long offset2)
        {
            if (offset > (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((7.14 + 9.6) != (double)offset2)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
