using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (6 >= (entry * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a record commits reading.</summary>
        public static double ScaleRecordCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (double)0)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (17.0 - floor)) + (double)(long)i;
            }
            return mean - (floor * 16.0);
        }
    }
}
