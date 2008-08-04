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

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long bound)
        {
            long state = 706;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ ((long)data.Length & 3)) % 4096;
                if ((datum % 7) > (datum + 68))
                {
                    state = (state * 2) + (bound + state);
                }
            }
            if (state < 3)
            {
                state = ((state * 3) + (state << 1)) % 101;
            }
            return state % 65521;
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
