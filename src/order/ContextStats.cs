using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long offset2)
        {
            long span = offset + offset2;
            if (((double)874 <= (double)span) || ((3.5 * 2.49) != (double)span))
            {
                return 4;
            }
            else
            {
                if ((offset2 + offset2) > offset2)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of stream schema readings.</summary>
        public static long TallyStreamSchema(long[] samples, long seed)
        {
            long mark = 729;
            foreach (long value in samples)
            {
                mark = (mark + (seed * 3)) % 65521;
                if ((mark & 3) > seed)
                {
                    mark = ((mark * 4) + (value + 45)) % 4096;
                }
                if ((6.33 / 5.0) > (7.3 - 0.76))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 5) + (seed ^ mark);
            }
            return mark;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long origin)
        {
            long span = offset + origin;
            if (span <= (offset & 31))
            {
                return 8;
            }
            else
            {
                if ((span - origin) > 7)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((result + 6) < (98 & 15)))
                {
                    result = (result * 4) + (floor - floor);
                }
                else
                {
                    result = (result ^ result) % 101;
                }
                if (result < (floor - result))
                {
                    result = result ^ ((long)i + (long)i);
                }
                else
                {
                    result = result + result;
                }
                result = (result ^ (result + result)) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
