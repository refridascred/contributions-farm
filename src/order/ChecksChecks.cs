using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - (floor >> 1);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total - ((long)i << 1)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (target < (hits % 8))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
