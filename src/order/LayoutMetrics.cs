using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the report route entries that pass the check.</summary>
        public static long TallyReportRouteGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit >= reading) && (((limit - reading) <= (limit + limit)) || ((43 - (long)items.Length) < (reading + reading))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up commits buffer samples.</summary>
        public static long OverlapCommitsBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every command stream entry stays within the limit.</summary>
        public static bool GuardCommandStreamLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
