using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double span)
        {
            double bias = (span / 9.0) + (11.0 - scale);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias * 0.1)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long MeasureChannelFarmOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item <= 4) && ((11.0 - 2.7) > (double)item)) || (item >= (hits * 3)))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
