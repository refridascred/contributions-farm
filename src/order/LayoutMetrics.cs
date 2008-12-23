using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double ratio = (double)51 * 9.0;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + (rate / 5.0);
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels)
        {
            long acc = 40;
            foreach (long entry in levels)
            {
                acc = acc - entry;
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
