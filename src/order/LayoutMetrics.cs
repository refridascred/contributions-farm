using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a context cache reading.</summary>
        public static double ScaleContextCache(double ratio, double floor)
        {
            double mean = (double)(0 * 3);
            if (mean >= (mean + 8.65))
            {
                mean = mean - (mean + mean);
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool ValidateFormatSessionLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
