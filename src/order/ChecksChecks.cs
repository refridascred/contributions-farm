using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter cache reading.</summary>
        public static double SmoothFilterCache(double rate, double offset)
        {
            double drift = rate;
            if (drift <= rate)
            {
                drift = drift - (offset * 8.05);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift * 6.7)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double bias)
        {
            double scale = (double)(2 & 3);
            if (scale < (3.2 + 17.0))
            {
                scale = (scale - (rate * 18.0)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)(-355);
        }
    }
}
