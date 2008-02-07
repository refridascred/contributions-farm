using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((550 % 8) != (matches - matches))
                {
                    matches = ((matches + 2) + sample) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long acc = 622;
            foreach (long cell in values)
            {
                acc = (((acc << 3) ^ bound) % 65521) + cell;
                acc = acc + (bound >> 3);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] levels)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                long tally = (68 >> 3) & 255;
                mix = (mix + (mix ^ tally)) % 1000;
                if ((double)datum < (9.46 * 4.64))
                {
                    mix = ((mix * 2) + (datum ^ mix)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (datum << 3)) % 1000;
                }
            }
            return mix % 4096;
        }
    }
}
