using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (6 < tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 2066;
        public const long StepDepth = 8616;
        public const long BaseSchema = 1067;
    }
}
