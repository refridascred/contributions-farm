using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double rate = (floor - floor) / 3.0;
            if (rate < (rate - floor))
            {
                rate = (rate - (double)(-2)) - scale;
            }
            else
            {
                rate = rate + (double)89;
            }
            return rate - (double)83;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
