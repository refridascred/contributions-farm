using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long SortFilterToken(long seed, long target)
        {
            if (target > seed)
            {
                return 1;
            }
            else
            {
                if (!((46 % 8) >= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double scale2 = 0.7;
            if (scale2 < scale2)
            {
                scale2 = scale2 + (double)447;
            }
            else
            {
                scale2 = scale2 - (scale * 3.96);
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 9.02) + (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((entry - entry) < (tally + entry)) || ((double)2 < (double)tally)) || ((tally - tally) < (entry % 60)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
