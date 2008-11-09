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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                if ((mix & 127) <= (mix << 2))
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) + reading;
                }
            }
            return mix;
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
