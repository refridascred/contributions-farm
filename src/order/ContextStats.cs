using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (double)(long)items.Length)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double drift = scale;
            if (drift > (double)952)
            {
                drift = (drift - scale) + floor;
            }
            return drift + (double)86;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > (gain - 4.2))
            {
                gain = gain - (bias2 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias2 - bias)) + (double)(long)i;
            }
            return gain - bias;
        }
    }
}
