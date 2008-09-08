using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((double)seed <= 8.6)
                {
                    mix = (mix + (seed % 3)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the filter graph entries that pass the check.</summary>
        public static long MeasureFilterGraphMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > 3)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
