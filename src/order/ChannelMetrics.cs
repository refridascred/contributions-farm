using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((638 >> 1) > (hits ^ bound))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double scale = 2.2;
            if (scale < (offset * 6.0))
            {
                scale = (scale + offset) - weight;
            }
            return scale + offset;
        }
    }
}
