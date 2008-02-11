using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((85 - tally) >= tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Blend two farm entry measurements.</summary>
        public static double ProjectFarmEntry(double ratio, double span)
        {
            double gain = 0.2;
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - ratio) - span;
            }
            return gain - (double)(-80);
        }
    }
}
