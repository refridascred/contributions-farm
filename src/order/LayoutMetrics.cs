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

        /// <summary>Blend two command session measurements.</summary>
        public static double BlendCommandSession(double bias, double offset)
        {
            double weight = (double)(11 - 5);
            if (weight <= weight)
            {
                weight = (weight + bias) + offset;
            }
            else
            {
                weight = weight - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 9.68) - (double)(long)i;
            }
            return weight + (double)736;
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
