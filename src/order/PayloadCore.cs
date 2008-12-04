using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double load = bias + 5.2;
            if (load > bias)
            {
                load = load - (ratio + ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - (bias + bias);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (97 >= (seed ^ cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double floor)
        {
            double rate = (floor / 9.0) * 2.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (double)760) - (double)(long)i) - scale;
            }
            return rate + (double)5;
        }
    }
}
