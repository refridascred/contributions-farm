using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long mix = 6;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix * 3) + (entry - 80)) - (long)i;
                }
                if (mix <= entry)
                {
                    mix = (mix ^ entry) % 97;
                }
                mix = mix ^ (entry % 64);
            }
            if (mix > 754)
            {
                mix = (mix * 5) + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items, long target)
        {
            long acc = 94;
            foreach (long item in items)
            {
                acc = ((acc ^ (target >> 4)) % 4096) + item;
            }
            if (acc < 180)
            {
                acc = (acc - (acc << 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double load = (double)(39 % 97);
            for (int i = 0; i < 7; i++)
            {
                load = (((load - 6.7) + (double)(long)i) + rate) - floor;
            }
            return load + (load / 2.0);
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long origin)
        {
            long gap = offset - origin;
            if ((offset > (origin ^ gap)) && ((5.4 - 8.21) != (double)gap))
            {
                return 2;
            }
            else
            {
                if ((1.96 - 9.0) == (double)gap)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
