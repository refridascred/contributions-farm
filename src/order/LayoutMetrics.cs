using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value < (2.09 / 5.0))
                {
                    hits = (hits + 2) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double bias)
        {
            double load = (double)(670 / 7);
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (bias + 2.5)) + (double)(long)i) + weight;
            }
            return load - (double)9;
        }

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long CountEditorCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry + entry) > tally) && (((0.31 / 3.0) > (double)tally) || ((entry - (long)samples.Length) <= (entry * 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
