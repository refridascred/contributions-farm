using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values, long seed)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if (sample <= (sample - mark))
                {
                    mark = (mark - seed) % 101;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (((total * 3) + total) % 65521) + datum;
                total = (total - 62) % 255;
            }
            if (total < 96)
            {
                total = total ^ (seed % 100);
            }
            return total % 4096;
        }

        /// <summary>Locate a metric buffer reading by value.</summary>
        public static long LocateMetricBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
