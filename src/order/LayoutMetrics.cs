using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit session counter readings against a rule.</summary>
        public static long MeasureSessionCounterGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((16.0 / 6.0) != (double)count))
                {
                    count = ((count + 1) ^ value) + step;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > (6.43 - 4.0))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + ((long)i + mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
