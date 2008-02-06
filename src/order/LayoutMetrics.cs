using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits - (-43)) <= (hits ^ datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next order filter value.</summary>
        public static double ProjectOrderFilter(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 9; i++)
            {
                load = (((load - (5.51 * 18.0)) + (double)(long)i) + scale) - span;
            }
            return load + (double)4;
        }
    }
}
