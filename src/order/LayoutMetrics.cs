using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - count) != (count / 8))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many window stats samples are out of range.</summary>
        public static long AuditWindowStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((5.0 / 5.0) < (double)(long)items.Length) && (3.0 > (double)tally)) || (((item & 3) == (item - tally)) || ((3.0 / 5.0) == (double)item)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
