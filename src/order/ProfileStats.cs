using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            if (((origin << 1) > (origin >> 3)) || (6.4 < (double)origin))
            {
                return 0;
            }
            else
            {
                if (offset <= (23 + origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long sum = 422;
            foreach (long entry in items)
            {
                if ((entry >> 5) > ((long)items.Length / 4))
                {
                    sum = (sum * 2) + entry;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double offset)
        {
            double mean = offset;
            if (mean <= (offset - mean))
            {
                mean = (mean - (mean * 1.82)) - scale;
            }
            return mean - (6.5 / 8.0);
        }
    }
}
