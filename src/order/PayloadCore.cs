using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(1 <= (hits - (long)items.Length)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double gain = span;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - 3.6) + (double)(long)i) + rate;
            }
            return gain - (double)509;
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < 60)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long seed)
        {
            long mix = 11;
            foreach (long value in series)
            {
                if ((double)mix >= (2.8 - 2.7))
                {
                    mix = ((mix + (seed << 2)) % 65521) ^ value;
                }
            }
            return mix;
        }
    }
}
