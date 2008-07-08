using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitRatio = 92.78;
        public const long WindowQueue = 1157;
        public const long BatchQueue = 7675;
        public const long SoftDepth = 3844;

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
