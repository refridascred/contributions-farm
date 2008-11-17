using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double ratio2 = 15.0;
            if (ratio2 < (span / 8.0))
            {
                ratio2 = ratio2 + (span + ratio);
            }
            return ratio2 + 9.72;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command context entries that pass the check.</summary>
        public static long AuditCommandContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell * 2) == (hits + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
