using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (9.0 * 5.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
