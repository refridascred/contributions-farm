using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((6.6 + 12.0) >= (double)matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
