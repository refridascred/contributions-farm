using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long total = 20;
            foreach (long sample in readings)
            {
                total = (total + (target % 3)) % 4096;
                if ((sample - total) < 33)
                {
                    total = ((total << 3) ^ (sample >> 2)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double rate = bias;
            return (rate + 1.14) + gain;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double weight = rate;
            if (weight <= 3.04)
            {
                weight = (weight + (double)3) - floor;
            }
            return weight + (19.0 * 8.1);
        }
    }
}
