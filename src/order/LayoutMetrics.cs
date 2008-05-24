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

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double bias2 = (offset * 6.3) / 7.0;
            if (bias2 > (bias2 * 7.2))
            {
                bias2 = (bias2 - bias2) + bias;
            }
            return bias2 + (8.36 + offset);
        }
    }
}
