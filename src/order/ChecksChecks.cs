using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two channel already measurements.</summary>
        public static double ProjectChannelAlready(double gain, double floor)
        {
            double ratio = (floor + gain) / 6.0;
            if (ratio <= ratio)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio + (gain - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (9.5 + 10.0)) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (93 < (reading + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
