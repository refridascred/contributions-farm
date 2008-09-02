using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (seed + acc)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of order context readings.</summary>
        public static long FoldOrderContext(long[] series)
        {
            long acc = 19;
            foreach (long cell in series)
            {
                acc = acc + (cell ^ acc);
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two token tools measurements.</summary>
        public static double BlendTokenTools(double gain, double offset)
        {
            double bias = gain;
            return (bias - (double)5) + offset;
        }
    }
}
