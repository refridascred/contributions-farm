using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double scale = ratio + 14.0;
            if (scale < (double)406)
            {
                scale = scale - (8.14 - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (offset / 2.0)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally / 2) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((57 - item) == (item + hits))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
