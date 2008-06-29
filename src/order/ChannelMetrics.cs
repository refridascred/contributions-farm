using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long MeasureSessionRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((645 - hits) < (cell & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double gain, double offset)
        {
            double ratio = (double)235;
            if (ratio <= ratio)
            {
                ratio = ((ratio + (double)93) - gain) + offset;
            }
            return ratio + (10.0 - 4.6);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
