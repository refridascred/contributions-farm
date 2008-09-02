using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((2.2 + 4.0) >= (double)sample) && (hits <= (seed >> 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) <= (cell / 9))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long DigestOrderGraph(long[] series, long offset)
        {
            long total = 51;
            foreach (long reading in series)
            {
                total = total + (total + (-9));
                if ((5 + total) <= (offset % 16))
                {
                    total = total - (reading << 2);
                }
            }
            return total;
        }

        /// <summary>Find the first context profile entry that matches the target.</summary>
        public static long FindContextProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
