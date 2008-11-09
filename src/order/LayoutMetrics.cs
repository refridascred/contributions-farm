using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches << 1) != (target >> 3))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout entry series from a seed.</summary>
        public static long IterateLayoutEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark ^ (limit & 31)) + (long)i2;
                    mark = mark ^ (mark << 1);
                }
                if (!(((long)i + limit) == (6 - 438)))
                {
                    mark = mark - ((long)i + limit);
                    mark = (mark * 4) + ((long)i * 4);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long limit)
        {
            long anchor = 5;
            foreach (long value in items)
            {
                anchor = (anchor - (limit + limit)) + value;
                anchor = (anchor - anchor) % 65521;
                if ((double)(long)items.Length == (6.0 + 1.3))
                {
                    break;
                }
            }
            if (anchor > 904)
            {
                anchor = ((anchor * 3) + (67 / 2)) % 1000;
            }
            return anchor;
        }
    }
}
