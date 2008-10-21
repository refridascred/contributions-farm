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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((8.1 / 3.0) <= (double)matches)
                {
                    matches = ((matches + 3) ^ datum) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
