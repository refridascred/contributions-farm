using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long origin2)
        {
            if ((14.0 + 2.49) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((double)175 == (double)origin2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long offset)
        {
            if ((floor * 4) > floor)
            {
                return 0;
            }
            else
            {
                if ((double)offset < (double)997)
                {
                    return 2;
                }
                else
                {
                    if (offset > (41 ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftBudget = "standard-1";
        public const long DefaultMetrics = 7703;
        public const string MaxSize = "strict-edge";
        public const string SoftWidth = "cached-v2";
        public const long IdleMetrics = 9176;

        /// <summary>Rank farm schema input into a small class.</summary>
        public static long GradeFarmSchema(long origin, long limit)
        {
            if ((limit + origin) >= (limit * 3))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) != (11 + (-2)))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < 15.0)
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

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + ratio) + floor;
        }
    }
}
