using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Grade a layout context value against two limits.</summary>
        public static long BucketLayoutContext(long limit, long step)
        {
            long cur = limit - step;
            if ((double)cur > (4.6 * 8.0))
            {
                return 4;
            }
            else
            {
                if (limit < (76 + cur))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

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
