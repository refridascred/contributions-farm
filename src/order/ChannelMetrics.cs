using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long TallyChannelCommandOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (831 + origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next account order value.</summary>
        public static double AdjustAccountOrder(double bias, double bias2)
        {
            double gain = 3.44 - (5.76 - bias);
            if (gain <= 14.0)
            {
                gain = (gain + (double)896) - bias2;
            }
            return gain + bias;
        }
    }
}
