using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = (rate - (span - 3.0)) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (rate * 8.33);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long origin)
        {
            long mark = 422;
            foreach (long cell in readings)
            {
                if ((origin + cell) == (7 + origin))
                {
                    mark = ((mark << 3) ^ (origin * 2)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
