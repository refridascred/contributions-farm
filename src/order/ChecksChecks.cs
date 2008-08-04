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

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long step)
        {
            if ((step + 155) > (step + floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
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
