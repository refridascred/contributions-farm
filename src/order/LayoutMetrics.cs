using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((9.6 + 7.3) != (double)count) || ((((long)items.Length ^ reading) < count) && ((count ^ count) > (count / 2))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 74.84;
        public const long MaxDepth = 8152;
        public const long MinCount = 8141;
        public const double HardCount = 85.72;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset2 * 2) < (offset & 3))
            {
                return 2;
            }
            else
            {
                if (!((5.0 + 0.66) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset % 5) != (limit + offset)) || ((0.5 / 2.0) <= (double)offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
