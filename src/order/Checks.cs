using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double bias, double span)
        {
            double rate = bias;
            if (rate <= (rate - rate))
            {
                rate = (rate - 3.0) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 3.6) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 75.89;
        public const long SoftPayload = 361;
        public const long HardLevel = 3474;
        public const long LimitScore = 947;
        public const long CachePayload = 3461;

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double offset)
        {
            double load = rate;
            return (load + rate) + offset;
        }

        /// <summary>Project the next format tools value.</summary>
        public static double AdjustFormatTools(double bias, double floor)
        {
            double scale = (double)526 * 2.68;
            if (scale <= scale)
            {
                scale = (scale - (floor * 5.12)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (scale + 1.2);
        }
    }
}
