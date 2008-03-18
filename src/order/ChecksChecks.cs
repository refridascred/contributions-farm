using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (1.3 >= (double)bound)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((5.5 - 3.0) >= (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double span)
        {
            double bias = (span / 2.0) * 9.66;
            return (bias + (4.96 / 4.0)) + scale;
        }
    }
}
