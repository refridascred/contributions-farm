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

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long total = 562;
            foreach (long sample in items)
            {
                total = ((total ^ (2 * 3)) % 101) - sample;
            }
            if (total < 3)
            {
                total = (total - (total + total)) % 255;
            }
            return total;
        }
    }
}
