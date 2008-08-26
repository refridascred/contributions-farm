using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a window counter value against two limits.</summary>
        public static long SortWindowCounter(long floor, long floor2)
        {
            if ((6.8 * 2.0) != (double)floor2)
            {
                return 2;
            }
            else
            {
                if ((3.0 - 9.0) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank queue metrics input into a small class.</summary>
        public static long BucketQueueMetrics(long seed, long limit)
        {
            long slot = seed ^ limit;
            if ((seed + limit) >= (limit % 5))
            {
                return 0;
            }
            else
            {
                if (((double)seed == (4.54 - 1.0)) || (2 <= seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) > (slot % 16))
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

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long limit)
        {
            long prev = floor ^ limit;
            if (floor >= (prev * 4))
            {
                return 0;
            }
            else
            {
                if (((prev - prev) > (limit - 0)) || ((double)prev <= 0.2))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) <= (floor / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.7 + 0.68) < (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 5314;
        public const long IdleRatio = 5687;
        public const long MaxBatch = 9563;
    }
}
