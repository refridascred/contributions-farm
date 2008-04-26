using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) >= (sample ^ (long)items.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double weight = (gain / 6.0) - (double)9;
            return (weight - 3.0) + bias;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values)
        {
            long mix = 6;
            foreach (long datum in values)
            {
                if ((4.72 - 15.0) > (double)mix)
                {
                    mix = ((mix * 2) + (153 << 2)) - datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double scale2 = (double)((-3) >> 5);
            if (scale2 <= (scale + bias))
            {
                scale2 = scale2 - (bias - scale2);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
