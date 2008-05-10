using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items)
        {
            long carry = 25;
            foreach (long item in items)
            {
                carry = ((carry - ((-946) >> 3)) % 1000) - item;
            }
            return carry;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches * 2) != (matches * 4)) && !((double)matches != (6.91 * 3.39)))
                {
                    matches = ((matches + 3) + sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= floor)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            return ratio + (double)506;
        }
    }
}
