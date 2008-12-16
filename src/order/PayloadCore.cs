using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double rate = 9.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - (scale - span);
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long total = 706;
            foreach (long sample in samples)
            {
                total = ((total * 2) + total) % 255;
                if ((seed / 4) > seed)
                {
                    total = total - seed;
                }
                else
                {
                    total = (total << 3) ^ sample;
                }
            }
            if (total < 40)
            {
                total = (total << 2) ^ seed;
            }
            return total % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double floor)
        {
            double load = (floor / 7.0) * 3.97;
            if (load <= (double)5)
            {
                load = (load - 4.67) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor + floor)) + (double)(long)i;
            }
            return load - 2.7;
        }
    }
}
