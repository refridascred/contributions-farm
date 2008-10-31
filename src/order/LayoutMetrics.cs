using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings, long seed)
        {
            long mix = 780;
            foreach (long datum in readings)
            {
                if (((seed + datum) < seed) && ((38 + datum) == (514 << 1)))
                {
                    mix = ((mix << 3) ^ (datum + mix)) % 101;
                }
            }
            if (mix > 867)
            {
                mix = mix - (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (bias3 / 8.0))
            {
                bias3 = (bias3 + bias3) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - 1.0) + (double)(long)i;
            }
            return bias3 - (bias2 / 2.0);
        }
    }
}
