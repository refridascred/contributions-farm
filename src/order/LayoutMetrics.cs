using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double bias, double span)
        {
            double gain = span;
            if (gain < (gain - bias))
            {
                gain = gain - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((double)tally != (5.93 * 6.0)))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
