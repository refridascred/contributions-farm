using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the command editor entries that pass the check.</summary>
        public static long CountCommandEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((2.22 + 5.67) < (double)floor)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long floor)
        {
            long mix = 7;
            foreach (long item in values)
            {
                mix = (((mix + (mix + mix)) % 1000) ^ item) - floor;
                if ((mix + mix) <= mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
