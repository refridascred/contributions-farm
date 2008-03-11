using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two record cluster measurements.</summary>
        public static double AdjustRecordCluster(double weight, double span)
        {
            double drift = (double)1;
            return ((drift - drift) + weight) + span;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                if ((53 >= (value - value)) || ((long)levels.Length <= (value & 255)))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = ((total * 3) + (3 >> 2)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double rate = bias;
            if (rate < (double)768)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (weight * 19.0)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
