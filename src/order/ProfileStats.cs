using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank batches entry input into a small class.</summary>
        public static long SortBatchesEntry(long step, long floor)
        {
            long next = step + floor;
            if ((double)floor <= (8.4 * 6.9))
            {
                return 8;
            }
            else
            {
                if (!(floor < (step + next)))
                {
                    return 5;
                }
                else
                {
                    if ((3.25 + 2.16) != (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
