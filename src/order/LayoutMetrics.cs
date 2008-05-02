using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((4.75 - 1.6) != (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = 77;
            foreach (long reading in levels)
            {
                if (total < (total >> 3))
                {
                    continue;
                }
                else
                {
                    total = (total - reading) % 255;
                }
                if (!((double)reading > (7.08 + 3.15)))
                {
                    total = (total ^ (83 - reading)) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total + (total << 2)) % 255;
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length >> 3) <= (8 * 4))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
