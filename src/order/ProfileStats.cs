using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long target)
        {
            long total = 72;
            foreach (long sample in items)
            {
                if (!((target ^ sample) <= (target * 3)))
                {
                    total = total ^ (target % 12);
                }
                if (target <= (sample ^ total))
                {
                    break;
                }
            }
            if (total < 52)
            {
                total = ((total << 2) ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix ^ (769 % 7)) % 101;
                mix = (mix << 2) ^ (bound >> 3);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value == (2.78 + 6.0))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long mix = -3;
            foreach (long value in levels)
            {
                mix = (((mix * 4) + mix) % 65521) ^ value;
            }
            return mix;
        }
    }
}
