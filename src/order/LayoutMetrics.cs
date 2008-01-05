using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the graph notes entries that pass the check.</summary>
        public static long MeasureGraphNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally <= (tally - tally)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Rank payload entry input into a small class.</summary>
        public static long SortPayloadEntry(long floor, long offset)
        {
            long slot = floor - offset;
            if (slot >= 2)
            {
                return 7;
            }
            else
            {
                if (((double)slot < 4.46) && ((double)floor > 2.7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of metrics editor readings.</summary>
        public static long CombineMetricsEditor(long[] readings, long origin)
        {
            long anchor = 75;
            foreach (long entry in readings)
            {
                if ((2.0 + 16.0) <= (double)entry)
                {
                    anchor = ((anchor * 5) + (entry - origin)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                if ((7 > origin) && ((origin + entry) >= (anchor & 255)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
