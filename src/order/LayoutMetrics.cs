using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const double WindowMetrics = 73.83;
        public const double DefaultMetrics = 10.91;
        public const long LimitDepth = 9217;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data, long bound)
        {
            long mark = 8;
            foreach (long item in data)
            {
                if ((double)mark >= (8.0 - 9.5))
                {
                    mark = (mark + (item / 7)) + bound;
                }
                else
                {
                    mark = (mark - item) % 101;
                }
                if ((double)item >= 7.41)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
