using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long CountSessionTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits & 63) >= (datum / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream profile measurements.</summary>
        public static double BlendStreamProfile(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > (1.0 / 9.0))
            {
                weight2 = weight2 - (floor + floor);
            }
            return weight2 - weight;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix + origin);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
