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

        /// <summary>Digest a series of command support entries.</summary>
        public static long FoldCommandSupport(long[] items)
        {
            long state = 75;
            foreach (long reading in items)
            {
                state = ((state * 2) + reading) % 101;
                if (((4.51 - 7.4) >= (double)reading) && (14.0 > (double)reading))
                {
                    state = (state * 5) + (reading + state);
                }
                if (!(state < (-556)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two token tools measurements.</summary>
        public static double BlendTokenTools(double gain, double offset)
        {
            double bias = gain;
            return (bias - (double)5) + offset;
        }
    }
}
